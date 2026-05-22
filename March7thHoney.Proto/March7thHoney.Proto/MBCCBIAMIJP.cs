using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MBCCBIAMIJP : IMessage<MBCCBIAMIJP>, IMessage, IEquatable<MBCCBIAMIJP>, IDeepCloneable<MBCCBIAMIJP>, IBufferMessage
{
	private static readonly MessageParser<MBCCBIAMIJP> _parser = new MessageParser<MBCCBIAMIJP>(() => new MBCCBIAMIJP());

	private UnknownFieldSet _unknownFields;

	public const int PCOEAPFCKCGFieldNumber = 10;

	private bool pCOEAPFCKCG_;

	public const int EntityIdFieldNumber = 12;

	private uint entityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MBCCBIAMIJP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MBCCBIAMIJPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PCOEAPFCKCG
	{
		get
		{
			return pCOEAPFCKCG_;
		}
		set
		{
			pCOEAPFCKCG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntityId
	{
		get
		{
			return entityId_;
		}
		set
		{
			entityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBCCBIAMIJP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBCCBIAMIJP(MBCCBIAMIJP other)
		: this()
	{
		pCOEAPFCKCG_ = other.pCOEAPFCKCG_;
		entityId_ = other.entityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBCCBIAMIJP Clone()
	{
		return new MBCCBIAMIJP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MBCCBIAMIJP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MBCCBIAMIJP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PCOEAPFCKCG != other.PCOEAPFCKCG)
		{
			return false;
		}
		if (EntityId != other.EntityId)
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
		if (PCOEAPFCKCG)
		{
			num ^= PCOEAPFCKCG.GetHashCode();
		}
		if (EntityId != 0)
		{
			num ^= EntityId.GetHashCode();
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
		if (PCOEAPFCKCG)
		{
			output.WriteRawTag(80);
			output.WriteBool(PCOEAPFCKCG);
		}
		if (EntityId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EntityId);
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
		if (PCOEAPFCKCG)
		{
			num += 2;
		}
		if (EntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MBCCBIAMIJP other)
	{
		if (other != null)
		{
			if (other.PCOEAPFCKCG)
			{
				PCOEAPFCKCG = other.PCOEAPFCKCG;
			}
			if (other.EntityId != 0)
			{
				EntityId = other.EntityId;
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
				PCOEAPFCKCG = input.ReadBool();
				break;
			case 96u:
				EntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
