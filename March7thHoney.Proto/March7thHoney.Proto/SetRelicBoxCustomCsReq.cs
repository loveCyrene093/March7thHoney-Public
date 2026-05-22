using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetRelicBoxCustomCsReq : IMessage<SetRelicBoxCustomCsReq>, IMessage, IEquatable<SetRelicBoxCustomCsReq>, IDeepCloneable<SetRelicBoxCustomCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetRelicBoxCustomCsReq> _parser = new MessageParser<SetRelicBoxCustomCsReq>(() => new SetRelicBoxCustomCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FFJDCNKPGOOFieldNumber = 7;

	private static readonly FieldCodec<NBIOEKILHEN> _repeated_fFJDCNKPGOO_codec = FieldCodec.ForMessage(58u, NBIOEKILHEN.Parser);

	private readonly RepeatedField<NBIOEKILHEN> fFJDCNKPGOO_ = new RepeatedField<NBIOEKILHEN>();

	public const int IAHIEBCFPCDFieldNumber = 11;

	private NBIOEKILHEN iAHIEBCFPCD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetRelicBoxCustomCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetRelicBoxCustomCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NBIOEKILHEN> FFJDCNKPGOO => fFJDCNKPGOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBIOEKILHEN IAHIEBCFPCD
	{
		get
		{
			return iAHIEBCFPCD_;
		}
		set
		{
			iAHIEBCFPCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRelicBoxCustomCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRelicBoxCustomCsReq(SetRelicBoxCustomCsReq other)
		: this()
	{
		fFJDCNKPGOO_ = other.fFJDCNKPGOO_.Clone();
		iAHIEBCFPCD_ = ((other.iAHIEBCFPCD_ != null) ? other.iAHIEBCFPCD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRelicBoxCustomCsReq Clone()
	{
		return new SetRelicBoxCustomCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetRelicBoxCustomCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetRelicBoxCustomCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fFJDCNKPGOO_.Equals(other.fFJDCNKPGOO_))
		{
			return false;
		}
		if (!object.Equals(IAHIEBCFPCD, other.IAHIEBCFPCD))
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
		num ^= fFJDCNKPGOO_.GetHashCode();
		if (iAHIEBCFPCD_ != null)
		{
			num ^= IAHIEBCFPCD.GetHashCode();
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
		fFJDCNKPGOO_.WriteTo(ref output, _repeated_fFJDCNKPGOO_codec);
		if (iAHIEBCFPCD_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(IAHIEBCFPCD);
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
		num += fFJDCNKPGOO_.CalculateSize(_repeated_fFJDCNKPGOO_codec);
		if (iAHIEBCFPCD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IAHIEBCFPCD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetRelicBoxCustomCsReq other)
	{
		if (other == null)
		{
			return;
		}
		fFJDCNKPGOO_.Add(other.fFJDCNKPGOO_);
		if (other.iAHIEBCFPCD_ != null)
		{
			if (iAHIEBCFPCD_ == null)
			{
				IAHIEBCFPCD = new NBIOEKILHEN();
			}
			IAHIEBCFPCD.MergeFrom(other.IAHIEBCFPCD);
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
			case 58u:
				fFJDCNKPGOO_.AddEntriesFrom(ref input, _repeated_fFJDCNKPGOO_codec);
				break;
			case 90u:
				if (iAHIEBCFPCD_ == null)
				{
					IAHIEBCFPCD = new NBIOEKILHEN();
				}
				input.ReadMessage(IAHIEBCFPCD);
				break;
			}
		}
	}
}
