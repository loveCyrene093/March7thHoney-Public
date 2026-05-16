using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NJJFPLFEEFC : IMessage<NJJFPLFEEFC>, IMessage, IEquatable<NJJFPLFEEFC>, IDeepCloneable<NJJFPLFEEFC>, IBufferMessage
{
	private static readonly MessageParser<NJJFPLFEEFC> _parser = new MessageParser<NJJFPLFEEFC>(() => new NJJFPLFEEFC());

	private UnknownFieldSet _unknownFields;

	public const int JHEIDLJEIBDFieldNumber = 2;

	private uint jHEIDLJEIBD_;

	public const int HBIKPPKANCHFieldNumber = 12;

	private uint hBIKPPKANCH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NJJFPLFEEFC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NJJFPLFEEFCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHEIDLJEIBD
	{
		get
		{
			return jHEIDLJEIBD_;
		}
		set
		{
			jHEIDLJEIBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBIKPPKANCH
	{
		get
		{
			return hBIKPPKANCH_;
		}
		set
		{
			hBIKPPKANCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJJFPLFEEFC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJJFPLFEEFC(NJJFPLFEEFC other)
		: this()
	{
		jHEIDLJEIBD_ = other.jHEIDLJEIBD_;
		hBIKPPKANCH_ = other.hBIKPPKANCH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJJFPLFEEFC Clone()
	{
		return new NJJFPLFEEFC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NJJFPLFEEFC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NJJFPLFEEFC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JHEIDLJEIBD != other.JHEIDLJEIBD)
		{
			return false;
		}
		if (HBIKPPKANCH != other.HBIKPPKANCH)
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
		if (JHEIDLJEIBD != 0)
		{
			num ^= JHEIDLJEIBD.GetHashCode();
		}
		if (HBIKPPKANCH != 0)
		{
			num ^= HBIKPPKANCH.GetHashCode();
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
		if (JHEIDLJEIBD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JHEIDLJEIBD);
		}
		if (HBIKPPKANCH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HBIKPPKANCH);
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
		if (JHEIDLJEIBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHEIDLJEIBD);
		}
		if (HBIKPPKANCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBIKPPKANCH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NJJFPLFEEFC other)
	{
		if (other != null)
		{
			if (other.JHEIDLJEIBD != 0)
			{
				JHEIDLJEIBD = other.JHEIDLJEIBD;
			}
			if (other.HBIKPPKANCH != 0)
			{
				HBIKPPKANCH = other.HBIKPPKANCH;
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
			case 16u:
				JHEIDLJEIBD = input.ReadUInt32();
				break;
			case 96u:
				HBIKPPKANCH = input.ReadUInt32();
				break;
			}
		}
	}
}
