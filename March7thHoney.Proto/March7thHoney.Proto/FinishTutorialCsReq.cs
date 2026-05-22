using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishTutorialCsReq : IMessage<FinishTutorialCsReq>, IMessage, IEquatable<FinishTutorialCsReq>, IDeepCloneable<FinishTutorialCsReq>, IBufferMessage
{
	private static readonly MessageParser<FinishTutorialCsReq> _parser = new MessageParser<FinishTutorialCsReq>(() => new FinishTutorialCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TutorialIdFieldNumber = 5;

	private uint tutorialId_;

	public const int NGJKIIIJBIBFieldNumber = 11;

	private TutorialFinishType nGJKIIIJBIB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishTutorialCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishTutorialCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TutorialId
	{
		get
		{
			return tutorialId_;
		}
		set
		{
			tutorialId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TutorialFinishType NGJKIIIJBIB
	{
		get
		{
			return nGJKIIIJBIB_;
		}
		set
		{
			nGJKIIIJBIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTutorialCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTutorialCsReq(FinishTutorialCsReq other)
		: this()
	{
		tutorialId_ = other.tutorialId_;
		nGJKIIIJBIB_ = other.nGJKIIIJBIB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTutorialCsReq Clone()
	{
		return new FinishTutorialCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishTutorialCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishTutorialCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TutorialId != other.TutorialId)
		{
			return false;
		}
		if (NGJKIIIJBIB != other.NGJKIIIJBIB)
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
		if (TutorialId != 0)
		{
			num ^= TutorialId.GetHashCode();
		}
		if (NGJKIIIJBIB != TutorialFinishType.GcpjlendficPcpdhelpkem)
		{
			num ^= NGJKIIIJBIB.GetHashCode();
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
		if (TutorialId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(TutorialId);
		}
		if (NGJKIIIJBIB != TutorialFinishType.GcpjlendficPcpdhelpkem)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)NGJKIIIJBIB);
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
		if (TutorialId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TutorialId);
		}
		if (NGJKIIIJBIB != TutorialFinishType.GcpjlendficPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NGJKIIIJBIB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishTutorialCsReq other)
	{
		if (other != null)
		{
			if (other.TutorialId != 0)
			{
				TutorialId = other.TutorialId;
			}
			if (other.NGJKIIIJBIB != TutorialFinishType.GcpjlendficPcpdhelpkem)
			{
				NGJKIIIJBIB = other.NGJKIIIJBIB;
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
			case 40u:
				TutorialId = input.ReadUInt32();
				break;
			case 88u:
				NGJKIIIJBIB = (TutorialFinishType)input.ReadEnum();
				break;
			}
		}
	}
}
