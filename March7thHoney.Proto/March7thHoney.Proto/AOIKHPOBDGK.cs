using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AOIKHPOBDGK : IMessage<AOIKHPOBDGK>, IMessage, IEquatable<AOIKHPOBDGK>, IDeepCloneable<AOIKHPOBDGK>, IBufferMessage
{
	private static readonly MessageParser<AOIKHPOBDGK> _parser = new MessageParser<AOIKHPOBDGK>(() => new AOIKHPOBDGK());

	private UnknownFieldSet _unknownFields;

	public const int ABAMHIFECNPFieldNumber = 1;

	private int aBAMHIFECNP_;

	public const int RankFieldNumber = 2;

	private uint rank_;

	public const int KKCFOIMCLCDFieldNumber = 6;

	private int kKCFOIMCLCD_;

	public const int BKPDBCAAGAEFieldNumber = 10;

	private uint bKPDBCAAGAE_;

	public const int ScoreIdFieldNumber = 12;

	private uint scoreId_;

	public const int JMIKPCPIFCDFieldNumber = 13;

	private static readonly FieldCodec<JGPAHLMGBML> _repeated_jMIKPCPIFCD_codec = FieldCodec.ForMessage(106u, JGPAHLMGBML.Parser);

	private readonly RepeatedField<JGPAHLMGBML> jMIKPCPIFCD_ = new RepeatedField<JGPAHLMGBML>();

	public const int PKAJLLIKJPLFieldNumber = 14;

	private uint pKAJLLIKJPL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AOIKHPOBDGK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AOIKHPOBDGKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ABAMHIFECNP
	{
		get
		{
			return aBAMHIFECNP_;
		}
		set
		{
			aBAMHIFECNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int KKCFOIMCLCD
	{
		get
		{
			return kKCFOIMCLCD_;
		}
		set
		{
			kKCFOIMCLCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BKPDBCAAGAE
	{
		get
		{
			return bKPDBCAAGAE_;
		}
		set
		{
			bKPDBCAAGAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JGPAHLMGBML> JMIKPCPIFCD => jMIKPCPIFCD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PKAJLLIKJPL
	{
		get
		{
			return pKAJLLIKJPL_;
		}
		set
		{
			pKAJLLIKJPL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOIKHPOBDGK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOIKHPOBDGK(AOIKHPOBDGK other)
		: this()
	{
		aBAMHIFECNP_ = other.aBAMHIFECNP_;
		rank_ = other.rank_;
		kKCFOIMCLCD_ = other.kKCFOIMCLCD_;
		bKPDBCAAGAE_ = other.bKPDBCAAGAE_;
		scoreId_ = other.scoreId_;
		jMIKPCPIFCD_ = other.jMIKPCPIFCD_.Clone();
		pKAJLLIKJPL_ = other.pKAJLLIKJPL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOIKHPOBDGK Clone()
	{
		return new AOIKHPOBDGK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AOIKHPOBDGK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AOIKHPOBDGK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ABAMHIFECNP != other.ABAMHIFECNP)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (KKCFOIMCLCD != other.KKCFOIMCLCD)
		{
			return false;
		}
		if (BKPDBCAAGAE != other.BKPDBCAAGAE)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (!jMIKPCPIFCD_.Equals(other.jMIKPCPIFCD_))
		{
			return false;
		}
		if (PKAJLLIKJPL != other.PKAJLLIKJPL)
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
		if (ABAMHIFECNP != 0)
		{
			num ^= ABAMHIFECNP.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (KKCFOIMCLCD != 0)
		{
			num ^= KKCFOIMCLCD.GetHashCode();
		}
		if (BKPDBCAAGAE != 0)
		{
			num ^= BKPDBCAAGAE.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		num ^= jMIKPCPIFCD_.GetHashCode();
		if (PKAJLLIKJPL != 0)
		{
			num ^= PKAJLLIKJPL.GetHashCode();
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
		if (ABAMHIFECNP != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ABAMHIFECNP);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Rank);
		}
		if (KKCFOIMCLCD != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(KKCFOIMCLCD);
		}
		if (BKPDBCAAGAE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BKPDBCAAGAE);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ScoreId);
		}
		jMIKPCPIFCD_.WriteTo(ref output, _repeated_jMIKPCPIFCD_codec);
		if (PKAJLLIKJPL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PKAJLLIKJPL);
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
		if (ABAMHIFECNP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ABAMHIFECNP);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (KKCFOIMCLCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KKCFOIMCLCD);
		}
		if (BKPDBCAAGAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BKPDBCAAGAE);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		num += jMIKPCPIFCD_.CalculateSize(_repeated_jMIKPCPIFCD_codec);
		if (PKAJLLIKJPL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKAJLLIKJPL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AOIKHPOBDGK other)
	{
		if (other != null)
		{
			if (other.ABAMHIFECNP != 0)
			{
				ABAMHIFECNP = other.ABAMHIFECNP;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.KKCFOIMCLCD != 0)
			{
				KKCFOIMCLCD = other.KKCFOIMCLCD;
			}
			if (other.BKPDBCAAGAE != 0)
			{
				BKPDBCAAGAE = other.BKPDBCAAGAE;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			jMIKPCPIFCD_.Add(other.jMIKPCPIFCD_);
			if (other.PKAJLLIKJPL != 0)
			{
				PKAJLLIKJPL = other.PKAJLLIKJPL;
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
				ABAMHIFECNP = input.ReadInt32();
				break;
			case 16u:
				Rank = input.ReadUInt32();
				break;
			case 48u:
				KKCFOIMCLCD = input.ReadInt32();
				break;
			case 80u:
				BKPDBCAAGAE = input.ReadUInt32();
				break;
			case 96u:
				ScoreId = input.ReadUInt32();
				break;
			case 106u:
				jMIKPCPIFCD_.AddEntriesFrom(ref input, _repeated_jMIKPCPIFCD_codec);
				break;
			case 112u:
				PKAJLLIKJPL = input.ReadUInt32();
				break;
			}
		}
	}
}
