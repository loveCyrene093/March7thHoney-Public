using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSwitchHandDataScRsp : IMessage<GetSwitchHandDataScRsp>, IMessage, IEquatable<GetSwitchHandDataScRsp>, IDeepCloneable<GetSwitchHandDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetSwitchHandDataScRsp> _parser = new MessageParser<GetSwitchHandDataScRsp>(() => new GetSwitchHandDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FPBJIFLGIMKFieldNumber = 4;

	private uint fPBJIFLGIMK_;

	public const int LFNIPECKNDHFieldNumber = 8;

	private static readonly FieldCodec<GODHDEIPDJL> _repeated_lFNIPECKNDH_codec = FieldCodec.ForMessage(66u, GODHDEIPDJL.Parser);

	private readonly RepeatedField<GODHDEIPDJL> lFNIPECKNDH_ = new RepeatedField<GODHDEIPDJL>();

	public const int AINLIAIGOJFFieldNumber = 13;

	private uint aINLIAIGOJF_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSwitchHandDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSwitchHandDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FPBJIFLGIMK
	{
		get
		{
			return fPBJIFLGIMK_;
		}
		set
		{
			fPBJIFLGIMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GODHDEIPDJL> LFNIPECKNDH => lFNIPECKNDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AINLIAIGOJF
	{
		get
		{
			return aINLIAIGOJF_;
		}
		set
		{
			aINLIAIGOJF_ = value;
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
	public GetSwitchHandDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchHandDataScRsp(GetSwitchHandDataScRsp other)
		: this()
	{
		fPBJIFLGIMK_ = other.fPBJIFLGIMK_;
		lFNIPECKNDH_ = other.lFNIPECKNDH_.Clone();
		aINLIAIGOJF_ = other.aINLIAIGOJF_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchHandDataScRsp Clone()
	{
		return new GetSwitchHandDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSwitchHandDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSwitchHandDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FPBJIFLGIMK != other.FPBJIFLGIMK)
		{
			return false;
		}
		if (!lFNIPECKNDH_.Equals(other.lFNIPECKNDH_))
		{
			return false;
		}
		if (AINLIAIGOJF != other.AINLIAIGOJF)
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
		if (FPBJIFLGIMK != 0)
		{
			num ^= FPBJIFLGIMK.GetHashCode();
		}
		num ^= lFNIPECKNDH_.GetHashCode();
		if (AINLIAIGOJF != 0)
		{
			num ^= AINLIAIGOJF.GetHashCode();
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
		if (FPBJIFLGIMK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(FPBJIFLGIMK);
		}
		lFNIPECKNDH_.WriteTo(ref output, _repeated_lFNIPECKNDH_codec);
		if (AINLIAIGOJF != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AINLIAIGOJF);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		if (FPBJIFLGIMK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FPBJIFLGIMK);
		}
		num += lFNIPECKNDH_.CalculateSize(_repeated_lFNIPECKNDH_codec);
		if (AINLIAIGOJF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AINLIAIGOJF);
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
	public void MergeFrom(GetSwitchHandDataScRsp other)
	{
		if (other != null)
		{
			if (other.FPBJIFLGIMK != 0)
			{
				FPBJIFLGIMK = other.FPBJIFLGIMK;
			}
			lFNIPECKNDH_.Add(other.lFNIPECKNDH_);
			if (other.AINLIAIGOJF != 0)
			{
				AINLIAIGOJF = other.AINLIAIGOJF;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 32u:
				FPBJIFLGIMK = input.ReadUInt32();
				break;
			case 66u:
				lFNIPECKNDH_.AddEntriesFrom(ref input, _repeated_lFNIPECKNDH_codec);
				break;
			case 104u:
				AINLIAIGOJF = input.ReadUInt32();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
