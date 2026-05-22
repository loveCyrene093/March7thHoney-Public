using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAiPamChatInfoScRsp : IMessage<GetAiPamChatInfoScRsp>, IMessage, IEquatable<GetAiPamChatInfoScRsp>, IDeepCloneable<GetAiPamChatInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAiPamChatInfoScRsp> _parser = new MessageParser<GetAiPamChatInfoScRsp>(() => new GetAiPamChatInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int AIPBFEOFNDOFieldNumber = 3;

	private string aIPBFEOFNDO_ = "";

	public const int HEFLHCHDDMGFieldNumber = 6;

	private bool hEFLHCHDDMG_;

	public const int MNDAIAGPOEIFieldNumber = 9;

	private bool mNDAIAGPOEI_;

	public const int FILFNMKCCNNFieldNumber = 11;

	private static readonly FieldCodec<MDOJCCMLKHP> _repeated_fILFNMKCCNN_codec = FieldCodec.ForMessage(90u, MDOJCCMLKHP.Parser);

	private readonly RepeatedField<MDOJCCMLKHP> fILFNMKCCNN_ = new RepeatedField<MDOJCCMLKHP>();

	public const int ECIAGLJNPMMFieldNumber = 12;

	private uint eCIAGLJNPMM_;

	public const int EKBMIOCOLICFieldNumber = 13;

	private bool eKBMIOCOLIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAiPamChatInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAiPamChatInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public string AIPBFEOFNDO
	{
		get
		{
			return aIPBFEOFNDO_;
		}
		set
		{
			aIPBFEOFNDO_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HEFLHCHDDMG
	{
		get
		{
			return hEFLHCHDDMG_;
		}
		set
		{
			hEFLHCHDDMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MNDAIAGPOEI
	{
		get
		{
			return mNDAIAGPOEI_;
		}
		set
		{
			mNDAIAGPOEI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MDOJCCMLKHP> FILFNMKCCNN => fILFNMKCCNN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ECIAGLJNPMM
	{
		get
		{
			return eCIAGLJNPMM_;
		}
		set
		{
			eCIAGLJNPMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EKBMIOCOLIC
	{
		get
		{
			return eKBMIOCOLIC_;
		}
		set
		{
			eKBMIOCOLIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAiPamChatInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAiPamChatInfoScRsp(GetAiPamChatInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		aIPBFEOFNDO_ = other.aIPBFEOFNDO_;
		hEFLHCHDDMG_ = other.hEFLHCHDDMG_;
		mNDAIAGPOEI_ = other.mNDAIAGPOEI_;
		fILFNMKCCNN_ = other.fILFNMKCCNN_.Clone();
		eCIAGLJNPMM_ = other.eCIAGLJNPMM_;
		eKBMIOCOLIC_ = other.eKBMIOCOLIC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAiPamChatInfoScRsp Clone()
	{
		return new GetAiPamChatInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAiPamChatInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAiPamChatInfoScRsp other)
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
		if (AIPBFEOFNDO != other.AIPBFEOFNDO)
		{
			return false;
		}
		if (HEFLHCHDDMG != other.HEFLHCHDDMG)
		{
			return false;
		}
		if (MNDAIAGPOEI != other.MNDAIAGPOEI)
		{
			return false;
		}
		if (!fILFNMKCCNN_.Equals(other.fILFNMKCCNN_))
		{
			return false;
		}
		if (ECIAGLJNPMM != other.ECIAGLJNPMM)
		{
			return false;
		}
		if (EKBMIOCOLIC != other.EKBMIOCOLIC)
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
		if (AIPBFEOFNDO.Length != 0)
		{
			num ^= AIPBFEOFNDO.GetHashCode();
		}
		if (HEFLHCHDDMG)
		{
			num ^= HEFLHCHDDMG.GetHashCode();
		}
		if (MNDAIAGPOEI)
		{
			num ^= MNDAIAGPOEI.GetHashCode();
		}
		num ^= fILFNMKCCNN_.GetHashCode();
		if (ECIAGLJNPMM != 0)
		{
			num ^= ECIAGLJNPMM.GetHashCode();
		}
		if (EKBMIOCOLIC)
		{
			num ^= EKBMIOCOLIC.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (AIPBFEOFNDO.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AIPBFEOFNDO);
		}
		if (HEFLHCHDDMG)
		{
			output.WriteRawTag(48);
			output.WriteBool(HEFLHCHDDMG);
		}
		if (MNDAIAGPOEI)
		{
			output.WriteRawTag(72);
			output.WriteBool(MNDAIAGPOEI);
		}
		fILFNMKCCNN_.WriteTo(ref output, _repeated_fILFNMKCCNN_codec);
		if (ECIAGLJNPMM != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ECIAGLJNPMM);
		}
		if (EKBMIOCOLIC)
		{
			output.WriteRawTag(104);
			output.WriteBool(EKBMIOCOLIC);
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
		if (AIPBFEOFNDO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AIPBFEOFNDO);
		}
		if (HEFLHCHDDMG)
		{
			num += 2;
		}
		if (MNDAIAGPOEI)
		{
			num += 2;
		}
		num += fILFNMKCCNN_.CalculateSize(_repeated_fILFNMKCCNN_codec);
		if (ECIAGLJNPMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ECIAGLJNPMM);
		}
		if (EKBMIOCOLIC)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAiPamChatInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.AIPBFEOFNDO.Length != 0)
			{
				AIPBFEOFNDO = other.AIPBFEOFNDO;
			}
			if (other.HEFLHCHDDMG)
			{
				HEFLHCHDDMG = other.HEFLHCHDDMG;
			}
			if (other.MNDAIAGPOEI)
			{
				MNDAIAGPOEI = other.MNDAIAGPOEI;
			}
			fILFNMKCCNN_.Add(other.fILFNMKCCNN_);
			if (other.ECIAGLJNPMM != 0)
			{
				ECIAGLJNPMM = other.ECIAGLJNPMM;
			}
			if (other.EKBMIOCOLIC)
			{
				EKBMIOCOLIC = other.EKBMIOCOLIC;
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 26u:
				AIPBFEOFNDO = input.ReadString();
				break;
			case 48u:
				HEFLHCHDDMG = input.ReadBool();
				break;
			case 72u:
				MNDAIAGPOEI = input.ReadBool();
				break;
			case 90u:
				fILFNMKCCNN_.AddEntriesFrom(ref input, _repeated_fILFNMKCCNN_codec);
				break;
			case 96u:
				ECIAGLJNPMM = input.ReadUInt32();
				break;
			case 104u:
				EKBMIOCOLIC = input.ReadBool();
				break;
			}
		}
	}
}
