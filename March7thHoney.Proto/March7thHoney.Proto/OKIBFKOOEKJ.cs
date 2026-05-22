using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OKIBFKOOEKJ : IMessage<OKIBFKOOEKJ>, IMessage, IEquatable<OKIBFKOOEKJ>, IDeepCloneable<OKIBFKOOEKJ>, IBufferMessage
{
	private static readonly MessageParser<OKIBFKOOEKJ> _parser = new MessageParser<OKIBFKOOEKJ>(() => new OKIBFKOOEKJ());

	private UnknownFieldSet _unknownFields;

	public const int LevelIdFieldNumber = 6;

	private uint levelId_;

	public const int BOBAOBPIELOFieldNumber = 7;

	private bool bOBAOBPIELO_;

	public const int DPNPCDGJPBGFieldNumber = 9;

	private bool dPNPCDGJPBG_;

	public const int IEPGKLIDHEKFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_iEPGKLIDHEK_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> iEPGKLIDHEK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OKIBFKOOEKJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OKIBFKOOEKJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BOBAOBPIELO
	{
		get
		{
			return bOBAOBPIELO_;
		}
		set
		{
			bOBAOBPIELO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DPNPCDGJPBG
	{
		get
		{
			return dPNPCDGJPBG_;
		}
		set
		{
			dPNPCDGJPBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IEPGKLIDHEK => iEPGKLIDHEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKIBFKOOEKJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKIBFKOOEKJ(OKIBFKOOEKJ other)
		: this()
	{
		levelId_ = other.levelId_;
		bOBAOBPIELO_ = other.bOBAOBPIELO_;
		dPNPCDGJPBG_ = other.dPNPCDGJPBG_;
		iEPGKLIDHEK_ = other.iEPGKLIDHEK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKIBFKOOEKJ Clone()
	{
		return new OKIBFKOOEKJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OKIBFKOOEKJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OKIBFKOOEKJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (BOBAOBPIELO != other.BOBAOBPIELO)
		{
			return false;
		}
		if (DPNPCDGJPBG != other.DPNPCDGJPBG)
		{
			return false;
		}
		if (!iEPGKLIDHEK_.Equals(other.iEPGKLIDHEK_))
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
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (BOBAOBPIELO)
		{
			num ^= BOBAOBPIELO.GetHashCode();
		}
		if (DPNPCDGJPBG)
		{
			num ^= DPNPCDGJPBG.GetHashCode();
		}
		num ^= iEPGKLIDHEK_.GetHashCode();
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
		if (LevelId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LevelId);
		}
		if (BOBAOBPIELO)
		{
			output.WriteRawTag(56);
			output.WriteBool(BOBAOBPIELO);
		}
		if (DPNPCDGJPBG)
		{
			output.WriteRawTag(72);
			output.WriteBool(DPNPCDGJPBG);
		}
		iEPGKLIDHEK_.WriteTo(ref output, _repeated_iEPGKLIDHEK_codec);
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
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (BOBAOBPIELO)
		{
			num += 2;
		}
		if (DPNPCDGJPBG)
		{
			num += 2;
		}
		num += iEPGKLIDHEK_.CalculateSize(_repeated_iEPGKLIDHEK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OKIBFKOOEKJ other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.BOBAOBPIELO)
			{
				BOBAOBPIELO = other.BOBAOBPIELO;
			}
			if (other.DPNPCDGJPBG)
			{
				DPNPCDGJPBG = other.DPNPCDGJPBG;
			}
			iEPGKLIDHEK_.Add(other.iEPGKLIDHEK_);
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
				LevelId = input.ReadUInt32();
				break;
			case 56u:
				BOBAOBPIELO = input.ReadBool();
				break;
			case 72u:
				DPNPCDGJPBG = input.ReadBool();
				break;
			case 80u:
			case 82u:
				iEPGKLIDHEK_.AddEntriesFrom(ref input, _repeated_iEPGKLIDHEK_codec);
				break;
			}
		}
	}
}
