using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSystemDataRsp : IMessage<GetSystemDataRsp>, IMessage, IEquatable<GetSystemDataRsp>, IDeepCloneable<GetSystemDataRsp>, IBufferMessage
{
	private static readonly MessageParser<GetSystemDataRsp> _parser = new MessageParser<GetSystemDataRsp>(() => new GetSystemDataRsp());

	private UnknownFieldSet _unknownFields;

	public const int DAMDPNDCACKFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dAMDPNDCACK_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dAMDPNDCACK_ = new RepeatedField<uint>();

	public const int AvatarListFieldNumber = 6;

	private static readonly FieldCodec<DiceCombatAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage(50u, DiceCombatAvatar.Parser);

	private readonly RepeatedField<DiceCombatAvatar> avatarList_ = new RepeatedField<DiceCombatAvatar>();

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int FKOBFPNGDCGFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_fKOBFPNGDCG_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> fKOBFPNGDCG_ = new RepeatedField<uint>();

	public const int FAMFCIPLGONFieldNumber = 11;

	private static readonly FieldCodec<INACEGAAALJ> _repeated_fAMFCIPLGON_codec = FieldCodec.ForMessage(90u, INACEGAAALJ.Parser);

	private readonly RepeatedField<INACEGAAALJ> fAMFCIPLGON_ = new RepeatedField<INACEGAAALJ>();

	public const int JEBJGKACBKDFieldNumber = 13;

	private uint jEBJGKACBKD_;

	public const int DKCGALDKDFAFieldNumber = 14;

	private DABNCEPBKMG dKCGALDKDFA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSystemDataRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSystemDataRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DAMDPNDCACK => dAMDPNDCACK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DiceCombatAvatar> AvatarList => avatarList_;

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
	public RepeatedField<uint> FKOBFPNGDCG => fKOBFPNGDCG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<INACEGAAALJ> FAMFCIPLGON => fAMFCIPLGON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JEBJGKACBKD
	{
		get
		{
			return jEBJGKACBKD_;
		}
		set
		{
			jEBJGKACBKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DABNCEPBKMG DKCGALDKDFA
	{
		get
		{
			return dKCGALDKDFA_;
		}
		set
		{
			dKCGALDKDFA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSystemDataRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSystemDataRsp(GetSystemDataRsp other)
		: this()
	{
		dAMDPNDCACK_ = other.dAMDPNDCACK_.Clone();
		avatarList_ = other.avatarList_.Clone();
		retcode_ = other.retcode_;
		fKOBFPNGDCG_ = other.fKOBFPNGDCG_.Clone();
		fAMFCIPLGON_ = other.fAMFCIPLGON_.Clone();
		jEBJGKACBKD_ = other.jEBJGKACBKD_;
		dKCGALDKDFA_ = ((other.dKCGALDKDFA_ != null) ? other.dKCGALDKDFA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSystemDataRsp Clone()
	{
		return new GetSystemDataRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSystemDataRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSystemDataRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dAMDPNDCACK_.Equals(other.dAMDPNDCACK_))
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!fKOBFPNGDCG_.Equals(other.fKOBFPNGDCG_))
		{
			return false;
		}
		if (!fAMFCIPLGON_.Equals(other.fAMFCIPLGON_))
		{
			return false;
		}
		if (JEBJGKACBKD != other.JEBJGKACBKD)
		{
			return false;
		}
		if (!object.Equals(DKCGALDKDFA, other.DKCGALDKDFA))
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
		num ^= dAMDPNDCACK_.GetHashCode();
		num ^= avatarList_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= fKOBFPNGDCG_.GetHashCode();
		num ^= fAMFCIPLGON_.GetHashCode();
		if (JEBJGKACBKD != 0)
		{
			num ^= JEBJGKACBKD.GetHashCode();
		}
		if (dKCGALDKDFA_ != null)
		{
			num ^= DKCGALDKDFA.GetHashCode();
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
		dAMDPNDCACK_.WriteTo(ref output, _repeated_dAMDPNDCACK_codec);
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		fKOBFPNGDCG_.WriteTo(ref output, _repeated_fKOBFPNGDCG_codec);
		fAMFCIPLGON_.WriteTo(ref output, _repeated_fAMFCIPLGON_codec);
		if (JEBJGKACBKD != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JEBJGKACBKD);
		}
		if (dKCGALDKDFA_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(DKCGALDKDFA);
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
		num += dAMDPNDCACK_.CalculateSize(_repeated_dAMDPNDCACK_codec);
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += fKOBFPNGDCG_.CalculateSize(_repeated_fKOBFPNGDCG_codec);
		num += fAMFCIPLGON_.CalculateSize(_repeated_fAMFCIPLGON_codec);
		if (JEBJGKACBKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JEBJGKACBKD);
		}
		if (dKCGALDKDFA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DKCGALDKDFA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetSystemDataRsp other)
	{
		if (other == null)
		{
			return;
		}
		dAMDPNDCACK_.Add(other.dAMDPNDCACK_);
		avatarList_.Add(other.avatarList_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		fKOBFPNGDCG_.Add(other.fKOBFPNGDCG_);
		fAMFCIPLGON_.Add(other.fAMFCIPLGON_);
		if (other.JEBJGKACBKD != 0)
		{
			JEBJGKACBKD = other.JEBJGKACBKD;
		}
		if (other.dKCGALDKDFA_ != null)
		{
			if (dKCGALDKDFA_ == null)
			{
				DKCGALDKDFA = new DABNCEPBKMG();
			}
			DKCGALDKDFA.MergeFrom(other.DKCGALDKDFA);
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
			case 24u:
			case 26u:
				dAMDPNDCACK_.AddEntriesFrom(ref input, _repeated_dAMDPNDCACK_codec);
				break;
			case 50u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				fKOBFPNGDCG_.AddEntriesFrom(ref input, _repeated_fKOBFPNGDCG_codec);
				break;
			case 90u:
				fAMFCIPLGON_.AddEntriesFrom(ref input, _repeated_fAMFCIPLGON_codec);
				break;
			case 104u:
				JEBJGKACBKD = input.ReadUInt32();
				break;
			case 114u:
				if (dKCGALDKDFA_ == null)
				{
					DKCGALDKDFA = new DABNCEPBKMG();
				}
				input.ReadMessage(DKCGALDKDFA);
				break;
			}
		}
	}
}
