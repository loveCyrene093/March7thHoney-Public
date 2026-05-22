using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PPBJILGAPBF : IMessage<PPBJILGAPBF>, IMessage, IEquatable<PPBJILGAPBF>, IDeepCloneable<PPBJILGAPBF>, IBufferMessage
{
	private static readonly MessageParser<PPBJILGAPBF> _parser = new MessageParser<PPBJILGAPBF>(() => new PPBJILGAPBF());

	private UnknownFieldSet _unknownFields;

	public const int AssistMonsterEntityIdListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> assistMonsterEntityIdList_ = new RepeatedField<uint>();

	public const int GGDPAAJFMJBFieldNumber = 15;

	private Vector gGDPAAJFMJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PPBJILGAPBF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PPBJILGAPBFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AssistMonsterEntityIdList => assistMonsterEntityIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector GGDPAAJFMJB
	{
		get
		{
			return gGDPAAJFMJB_;
		}
		set
		{
			gGDPAAJFMJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPBJILGAPBF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPBJILGAPBF(PPBJILGAPBF other)
		: this()
	{
		assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
		gGDPAAJFMJB_ = ((other.gGDPAAJFMJB_ != null) ? other.gGDPAAJFMJB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPBJILGAPBF Clone()
	{
		return new PPBJILGAPBF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PPBJILGAPBF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PPBJILGAPBF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_))
		{
			return false;
		}
		if (!object.Equals(GGDPAAJFMJB, other.GGDPAAJFMJB))
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
		num ^= assistMonsterEntityIdList_.GetHashCode();
		if (gGDPAAJFMJB_ != null)
		{
			num ^= GGDPAAJFMJB.GetHashCode();
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
		assistMonsterEntityIdList_.WriteTo(ref output, _repeated_assistMonsterEntityIdList_codec);
		if (gGDPAAJFMJB_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(GGDPAAJFMJB);
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
		num += assistMonsterEntityIdList_.CalculateSize(_repeated_assistMonsterEntityIdList_codec);
		if (gGDPAAJFMJB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GGDPAAJFMJB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PPBJILGAPBF other)
	{
		if (other == null)
		{
			return;
		}
		assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
		if (other.gGDPAAJFMJB_ != null)
		{
			if (gGDPAAJFMJB_ == null)
			{
				GGDPAAJFMJB = new Vector();
			}
			GGDPAAJFMJB.MergeFrom(other.GGDPAAJFMJB);
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
			case 48u:
			case 50u:
				assistMonsterEntityIdList_.AddEntriesFrom(ref input, _repeated_assistMonsterEntityIdList_codec);
				break;
			case 122u:
				if (gGDPAAJFMJB_ == null)
				{
					GGDPAAJFMJB = new Vector();
				}
				input.ReadMessage(GGDPAAJFMJB);
				break;
			}
		}
	}
}
