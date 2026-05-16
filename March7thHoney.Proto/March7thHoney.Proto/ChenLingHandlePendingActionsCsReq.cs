using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingHandlePendingActionsCsReq : IMessage<ChenLingHandlePendingActionsCsReq>, IMessage, IEquatable<ChenLingHandlePendingActionsCsReq>, IDeepCloneable<ChenLingHandlePendingActionsCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChenLingHandlePendingActionsCsReq> _parser = new MessageParser<ChenLingHandlePendingActionsCsReq>(() => new ChenLingHandlePendingActionsCsReq());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 12;

	private uint uniqueId_;

	public const int ICKIIBGJMNMFieldNumber = 1038;

	private NGDOLHONKIA iCKIIBGJMNM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingHandlePendingActionsCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingHandlePendingActionsCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGDOLHONKIA ICKIIBGJMNM
	{
		get
		{
			return iCKIIBGJMNM_;
		}
		set
		{
			iCKIIBGJMNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingHandlePendingActionsCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingHandlePendingActionsCsReq(ChenLingHandlePendingActionsCsReq other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		iCKIIBGJMNM_ = ((other.iCKIIBGJMNM_ != null) ? other.iCKIIBGJMNM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingHandlePendingActionsCsReq Clone()
	{
		return new ChenLingHandlePendingActionsCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingHandlePendingActionsCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingHandlePendingActionsCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(ICKIIBGJMNM, other.ICKIIBGJMNM))
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (iCKIIBGJMNM_ != null)
		{
			num ^= ICKIIBGJMNM.GetHashCode();
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(UniqueId);
		}
		if (iCKIIBGJMNM_ != null)
		{
			output.WriteRawTag(242, 64);
			output.WriteMessage(ICKIIBGJMNM);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (iCKIIBGJMNM_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ICKIIBGJMNM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingHandlePendingActionsCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.iCKIIBGJMNM_ != null)
		{
			if (iCKIIBGJMNM_ == null)
			{
				ICKIIBGJMNM = new NGDOLHONKIA();
			}
			ICKIIBGJMNM.MergeFrom(other.ICKIIBGJMNM);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 96u:
				UniqueId = input.ReadUInt32();
				break;
			case 8306u:
				if (iCKIIBGJMNM_ == null)
				{
					ICKIIBGJMNM = new NGDOLHONKIA();
				}
				input.ReadMessage(ICKIIBGJMNM);
				break;
			}
		}
	}
}
