using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournEnablePermanentTalentScRsp : IMessage<RogueTournEnablePermanentTalentScRsp>, IMessage, IEquatable<RogueTournEnablePermanentTalentScRsp>, IDeepCloneable<RogueTournEnablePermanentTalentScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournEnablePermanentTalentScRsp> _parser = new MessageParser<RogueTournEnablePermanentTalentScRsp>(() => new RogueTournEnablePermanentTalentScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FMKEFGJMCHAFieldNumber = 1;

	private ECJNAIOLKJD fMKEFGJMCHA_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournEnablePermanentTalentScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournEnablePermanentTalentScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RogueTournEnablePermanentTalentScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnablePermanentTalentScRsp(RogueTournEnablePermanentTalentScRsp other)
		: this()
	{
		fMKEFGJMCHA_ = ((other.fMKEFGJMCHA_ != null) ? other.fMKEFGJMCHA_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnablePermanentTalentScRsp Clone()
	{
		return new RogueTournEnablePermanentTalentScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournEnablePermanentTalentScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournEnablePermanentTalentScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FMKEFGJMCHA, other.FMKEFGJMCHA))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (fMKEFGJMCHA_ != null)
		{
			num ^= FMKEFGJMCHA.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (fMKEFGJMCHA_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FMKEFGJMCHA);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
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
		if (fMKEFGJMCHA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FMKEFGJMCHA);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournEnablePermanentTalentScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fMKEFGJMCHA_ != null)
		{
			if (fMKEFGJMCHA_ == null)
			{
				FMKEFGJMCHA = new ECJNAIOLKJD();
			}
			FMKEFGJMCHA.MergeFrom(other.FMKEFGJMCHA);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 10u:
				if (fMKEFGJMCHA_ == null)
				{
					FMKEFGJMCHA = new ECJNAIOLKJD();
				}
				input.ReadMessage(FMKEFGJMCHA);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
