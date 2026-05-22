using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DMINLLDNNDL : IMessage<DMINLLDNNDL>, IMessage, IEquatable<DMINLLDNNDL>, IDeepCloneable<DMINLLDNNDL>, IBufferMessage
{
	private static readonly MessageParser<DMINLLDNNDL> _parser = new MessageParser<DMINLLDNNDL>(() => new DMINLLDNNDL());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 7;

	private uint id_;

	public const int ABMKKOKDAFKFieldNumber = 13;

	private uint aBMKKOKDAFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DMINLLDNNDL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DMINLLDNNDLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ABMKKOKDAFK
	{
		get
		{
			return aBMKKOKDAFK_;
		}
		set
		{
			aBMKKOKDAFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMINLLDNNDL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMINLLDNNDL(DMINLLDNNDL other)
		: this()
	{
		id_ = other.id_;
		aBMKKOKDAFK_ = other.aBMKKOKDAFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMINLLDNNDL Clone()
	{
		return new DMINLLDNNDL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DMINLLDNNDL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DMINLLDNNDL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (ABMKKOKDAFK != other.ABMKKOKDAFK)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ABMKKOKDAFK != 0)
		{
			num ^= ABMKKOKDAFK.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Id);
		}
		if (ABMKKOKDAFK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ABMKKOKDAFK);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (ABMKKOKDAFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABMKKOKDAFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DMINLLDNNDL other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ABMKKOKDAFK != 0)
			{
				ABMKKOKDAFK = other.ABMKKOKDAFK;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 56u:
				Id = input.ReadUInt32();
				break;
			case 104u:
				ABMKKOKDAFK = input.ReadUInt32();
				break;
			}
		}
	}
}
