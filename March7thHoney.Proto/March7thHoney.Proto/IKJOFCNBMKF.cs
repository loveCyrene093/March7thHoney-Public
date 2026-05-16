using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IKJOFCNBMKF : IMessage<IKJOFCNBMKF>, IMessage, IEquatable<IKJOFCNBMKF>, IDeepCloneable<IKJOFCNBMKF>, IBufferMessage
{
	private static readonly MessageParser<IKJOFCNBMKF> _parser = new MessageParser<IKJOFCNBMKF>(() => new IKJOFCNBMKF());

	private UnknownFieldSet _unknownFields;

	public const int IEIHJEKMLHHFieldNumber = 10;

	private uint iEIHJEKMLHH_;

	public const int BuffIdFieldNumber = 15;

	private uint buffId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IKJOFCNBMKF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IKJOFCNBMKFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IEIHJEKMLHH
	{
		get
		{
			return iEIHJEKMLHH_;
		}
		set
		{
			iEIHJEKMLHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKJOFCNBMKF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKJOFCNBMKF(IKJOFCNBMKF other)
		: this()
	{
		iEIHJEKMLHH_ = other.iEIHJEKMLHH_;
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKJOFCNBMKF Clone()
	{
		return new IKJOFCNBMKF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IKJOFCNBMKF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IKJOFCNBMKF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IEIHJEKMLHH != other.IEIHJEKMLHH)
		{
			return false;
		}
		if (BuffId != other.BuffId)
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
		if (IEIHJEKMLHH != 0)
		{
			num ^= IEIHJEKMLHH.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
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
		if (IEIHJEKMLHH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IEIHJEKMLHH);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BuffId);
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
		if (IEIHJEKMLHH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEIHJEKMLHH);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IKJOFCNBMKF other)
	{
		if (other != null)
		{
			if (other.IEIHJEKMLHH != 0)
			{
				IEIHJEKMLHH = other.IEIHJEKMLHH;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
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
			case 80u:
				IEIHJEKMLHH = input.ReadUInt32();
				break;
			case 120u:
				BuffId = input.ReadUInt32();
				break;
			}
		}
	}
}
