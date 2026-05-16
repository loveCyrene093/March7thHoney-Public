using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractPropCsReq : IMessage<InteractPropCsReq>, IMessage, IEquatable<InteractPropCsReq>, IDeepCloneable<InteractPropCsReq>, IBufferMessage
{
	private static readonly MessageParser<InteractPropCsReq> _parser = new MessageParser<InteractPropCsReq>(() => new InteractPropCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PropEntityIdFieldNumber = 8;

	private uint propEntityId_;

	public const int InteractIdFieldNumber = 10;

	private ulong interactId_;

	public const int InteractId2FieldNumber = 15;

	private uint interactId2_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<InteractPropCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => InteractPropCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PropEntityId
	{
		get
		{
			return propEntityId_;
		}
		set
		{
			propEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InteractId2
	{
		get
		{
			return interactId2_;
		}
		set
		{
			interactId2_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractPropCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractPropCsReq(InteractPropCsReq other)
		: this()
	{
		propEntityId_ = other.propEntityId_;
		interactId_ = other.interactId_;
		interactId2_ = other.interactId2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractPropCsReq Clone()
	{
		return new InteractPropCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as InteractPropCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InteractPropCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PropEntityId != other.PropEntityId)
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (InteractId2 != other.InteractId2)
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
		if (PropEntityId != 0)
		{
			num ^= PropEntityId.GetHashCode();
		}
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
		if (InteractId2 != 0)
		{
			num ^= InteractId2.GetHashCode();
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
		if (PropEntityId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PropEntityId);
		}
		if (InteractId != 0L)
		{
			output.WriteRawTag(80);
			output.WriteUInt64(InteractId);
		}
		if (InteractId2 != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(InteractId2);
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
		if (PropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropEntityId);
		}
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		if (InteractId2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InteractId2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(InteractPropCsReq other)
	{
		if (other != null)
		{
			if (other.PropEntityId != 0)
			{
				PropEntityId = other.PropEntityId;
			}
			if (other.InteractId != 0L)
			{
				InteractId = other.InteractId;
			}
			if (other.InteractId2 != 0)
			{
				InteractId2 = other.InteractId2;
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
			case 64u:
				PropEntityId = input.ReadUInt32();
				break;
			case 80u:
				InteractId = input.ReadUInt64();
				break;
			case 120u:
				InteractId2 = input.ReadUInt32();
				break;
			}
		}
	}
}
