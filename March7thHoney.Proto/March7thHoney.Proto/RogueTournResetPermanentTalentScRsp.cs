using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournResetPermanentTalentScRsp : IMessage<RogueTournResetPermanentTalentScRsp>, IMessage, IEquatable<RogueTournResetPermanentTalentScRsp>, IDeepCloneable<RogueTournResetPermanentTalentScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournResetPermanentTalentScRsp> _parser = new MessageParser<RogueTournResetPermanentTalentScRsp>(() => new RogueTournResetPermanentTalentScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int FMKEFGJMCHAFieldNumber = 6;

	private ECJNAIOLKJD fMKEFGJMCHA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournResetPermanentTalentScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournResetPermanentTalentScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECJNAIOLKJD FMKEFGJMCHA
	{
		get
		{
			return fMKEFGJMCHA_;
		}
		set
		{
			fMKEFGJMCHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournResetPermanentTalentScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournResetPermanentTalentScRsp(RogueTournResetPermanentTalentScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		fMKEFGJMCHA_ = ((other.fMKEFGJMCHA_ != null) ? other.fMKEFGJMCHA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournResetPermanentTalentScRsp Clone()
	{
		return new RogueTournResetPermanentTalentScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournResetPermanentTalentScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournResetPermanentTalentScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(FMKEFGJMCHA, other.FMKEFGJMCHA))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (fMKEFGJMCHA_ != null)
		{
			num ^= FMKEFGJMCHA.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (fMKEFGJMCHA_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(FMKEFGJMCHA);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (fMKEFGJMCHA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FMKEFGJMCHA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournResetPermanentTalentScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.fMKEFGJMCHA_ != null)
		{
			if (fMKEFGJMCHA_ == null)
			{
				FMKEFGJMCHA = new ECJNAIOLKJD();
			}
			FMKEFGJMCHA.MergeFrom(other.FMKEFGJMCHA);
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
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 50u:
				if (fMKEFGJMCHA_ == null)
				{
					FMKEFGJMCHA = new ECJNAIOLKJD();
				}
				input.ReadMessage(FMKEFGJMCHA);
				break;
			}
		}
	}
}
