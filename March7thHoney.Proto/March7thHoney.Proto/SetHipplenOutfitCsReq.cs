using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetHipplenOutfitCsReq : IMessage<SetHipplenOutfitCsReq>, IMessage, IEquatable<SetHipplenOutfitCsReq>, IDeepCloneable<SetHipplenOutfitCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetHipplenOutfitCsReq> _parser = new MessageParser<SetHipplenOutfitCsReq>(() => new SetHipplenOutfitCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FKEGMMKNHONFieldNumber = 14;

	private uint fKEGMMKNHON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetHipplenOutfitCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetHipplenOutfitCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FKEGMMKNHON
	{
		get
		{
			return fKEGMMKNHON_;
		}
		set
		{
			fKEGMMKNHON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetHipplenOutfitCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetHipplenOutfitCsReq(SetHipplenOutfitCsReq other)
		: this()
	{
		fKEGMMKNHON_ = other.fKEGMMKNHON_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetHipplenOutfitCsReq Clone()
	{
		return new SetHipplenOutfitCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetHipplenOutfitCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetHipplenOutfitCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FKEGMMKNHON != other.FKEGMMKNHON)
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
		if (FKEGMMKNHON != 0)
		{
			num ^= FKEGMMKNHON.GetHashCode();
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
		if (FKEGMMKNHON != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FKEGMMKNHON);
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
		if (FKEGMMKNHON != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKEGMMKNHON);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetHipplenOutfitCsReq other)
	{
		if (other != null)
		{
			if (other.FKEGMMKNHON != 0)
			{
				FKEGMMKNHON = other.FKEGMMKNHON;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				FKEGMMKNHON = input.ReadUInt32();
			}
		}
	}
}
