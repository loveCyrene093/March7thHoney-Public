using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LMIFJBLJFHP : IMessage<LMIFJBLJFHP>, IMessage, IEquatable<LMIFJBLJFHP>, IDeepCloneable<LMIFJBLJFHP>, IBufferMessage
{
	private static readonly MessageParser<LMIFJBLJFHP> _parser = new MessageParser<LMIFJBLJFHP>(() => new LMIFJBLJFHP());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 6;

	private RogueTalentStatus status_;

	public const int KFJEMIOJLPJFieldNumber = 11;

	private uint kFJEMIOJLPJ_;

	public const int GHECCPNMCMDFieldNumber = 15;

	private static readonly FieldCodec<OOBPMAOBPOJ> _repeated_gHECCPNMCMD_codec = FieldCodec.ForMessage(122u, OOBPMAOBPOJ.Parser);

	private readonly RepeatedField<OOBPMAOBPOJ> gHECCPNMCMD_ = new RepeatedField<OOBPMAOBPOJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LMIFJBLJFHP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LMIFJBLJFHPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTalentStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KFJEMIOJLPJ
	{
		get
		{
			return kFJEMIOJLPJ_;
		}
		set
		{
			kFJEMIOJLPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OOBPMAOBPOJ> GHECCPNMCMD => gHECCPNMCMD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMIFJBLJFHP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMIFJBLJFHP(LMIFJBLJFHP other)
		: this()
	{
		status_ = other.status_;
		kFJEMIOJLPJ_ = other.kFJEMIOJLPJ_;
		gHECCPNMCMD_ = other.gHECCPNMCMD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMIFJBLJFHP Clone()
	{
		return new LMIFJBLJFHP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LMIFJBLJFHP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LMIFJBLJFHP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (KFJEMIOJLPJ != other.KFJEMIOJLPJ)
		{
			return false;
		}
		if (!gHECCPNMCMD_.Equals(other.gHECCPNMCMD_))
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
		if (Status != RogueTalentStatus.JhidlbhjpbjDklpaafflee)
		{
			num ^= Status.GetHashCode();
		}
		if (KFJEMIOJLPJ != 0)
		{
			num ^= KFJEMIOJLPJ.GetHashCode();
		}
		num ^= gHECCPNMCMD_.GetHashCode();
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
		if (Status != RogueTalentStatus.JhidlbhjpbjDklpaafflee)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Status);
		}
		if (KFJEMIOJLPJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KFJEMIOJLPJ);
		}
		gHECCPNMCMD_.WriteTo(ref output, _repeated_gHECCPNMCMD_codec);
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
		if (Status != RogueTalentStatus.JhidlbhjpbjDklpaafflee)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (KFJEMIOJLPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KFJEMIOJLPJ);
		}
		num += gHECCPNMCMD_.CalculateSize(_repeated_gHECCPNMCMD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LMIFJBLJFHP other)
	{
		if (other != null)
		{
			if (other.Status != RogueTalentStatus.JhidlbhjpbjDklpaafflee)
			{
				Status = other.Status;
			}
			if (other.KFJEMIOJLPJ != 0)
			{
				KFJEMIOJLPJ = other.KFJEMIOJLPJ;
			}
			gHECCPNMCMD_.Add(other.gHECCPNMCMD_);
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
			case 48u:
				Status = (RogueTalentStatus)input.ReadEnum();
				break;
			case 88u:
				KFJEMIOJLPJ = input.ReadUInt32();
				break;
			case 122u:
				gHECCPNMCMD_.AddEntriesFrom(ref input, _repeated_gHECCPNMCMD_codec);
				break;
			}
		}
	}
}
