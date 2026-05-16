using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntityBindPropCsReq : IMessage<EntityBindPropCsReq>, IMessage, IEquatable<EntityBindPropCsReq>, IDeepCloneable<EntityBindPropCsReq>, IBufferMessage
{
	private static readonly MessageParser<EntityBindPropCsReq> _parser = new MessageParser<EntityBindPropCsReq>(() => new EntityBindPropCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PFAKHCCEEEKFieldNumber = 4;

	private bool pFAKHCCEEEK_;

	public const int MotionFieldNumber = 11;

	private MotionInfo motion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EntityBindPropCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EntityBindPropCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PFAKHCCEEEK
	{
		get
		{
			return pFAKHCCEEEK_;
		}
		set
		{
			pFAKHCCEEEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo Motion
	{
		get
		{
			return motion_;
		}
		set
		{
			motion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityBindPropCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityBindPropCsReq(EntityBindPropCsReq other)
		: this()
	{
		pFAKHCCEEEK_ = other.pFAKHCCEEEK_;
		motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityBindPropCsReq Clone()
	{
		return new EntityBindPropCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EntityBindPropCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EntityBindPropCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PFAKHCCEEEK != other.PFAKHCCEEEK)
		{
			return false;
		}
		if (!object.Equals(Motion, other.Motion))
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
		if (PFAKHCCEEEK)
		{
			num ^= PFAKHCCEEEK.GetHashCode();
		}
		if (motion_ != null)
		{
			num ^= Motion.GetHashCode();
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
		if (PFAKHCCEEEK)
		{
			output.WriteRawTag(32);
			output.WriteBool(PFAKHCCEEEK);
		}
		if (motion_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(Motion);
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
		if (PFAKHCCEEEK)
		{
			num += 2;
		}
		if (motion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Motion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EntityBindPropCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PFAKHCCEEEK)
		{
			PFAKHCCEEEK = other.PFAKHCCEEEK;
		}
		if (other.motion_ != null)
		{
			if (motion_ == null)
			{
				Motion = new MotionInfo();
			}
			Motion.MergeFrom(other.Motion);
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
			case 32u:
				PFAKHCCEEEK = input.ReadBool();
				break;
			case 90u:
				if (motion_ == null)
				{
					Motion = new MotionInfo();
				}
				input.ReadMessage(Motion);
				break;
			}
		}
	}
}
