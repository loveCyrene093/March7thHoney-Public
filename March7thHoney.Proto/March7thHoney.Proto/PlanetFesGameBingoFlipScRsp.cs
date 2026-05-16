using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesGameBingoFlipScRsp : IMessage<PlanetFesGameBingoFlipScRsp>, IMessage, IEquatable<PlanetFesGameBingoFlipScRsp>, IDeepCloneable<PlanetFesGameBingoFlipScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesGameBingoFlipScRsp> _parser = new MessageParser<PlanetFesGameBingoFlipScRsp>(() => new PlanetFesGameBingoFlipScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NBFLCNHFEFMFieldNumber = 3;

	private uint nBFLCNHFEFM_;

	public const int JKLFMOHICMOFieldNumber = 4;

	private bool jKLFMOHICMO_;

	public const int RewardFieldNumber = 8;

	private HLLCDBLCIPK reward_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesGameBingoFlipScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesGameBingoFlipScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NBFLCNHFEFM
	{
		get
		{
			return nBFLCNHFEFM_;
		}
		set
		{
			nBFLCNHFEFM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JKLFMOHICMO
	{
		get
		{
			return jKLFMOHICMO_;
		}
		set
		{
			jKLFMOHICMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLLCDBLCIPK Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
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
	public PlanetFesGameBingoFlipScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGameBingoFlipScRsp(PlanetFesGameBingoFlipScRsp other)
		: this()
	{
		nBFLCNHFEFM_ = other.nBFLCNHFEFM_;
		jKLFMOHICMO_ = other.jKLFMOHICMO_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGameBingoFlipScRsp Clone()
	{
		return new PlanetFesGameBingoFlipScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesGameBingoFlipScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesGameBingoFlipScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NBFLCNHFEFM != other.NBFLCNHFEFM)
		{
			return false;
		}
		if (JKLFMOHICMO != other.JKLFMOHICMO)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
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
		if (NBFLCNHFEFM != 0)
		{
			num ^= NBFLCNHFEFM.GetHashCode();
		}
		if (JKLFMOHICMO)
		{
			num ^= JKLFMOHICMO.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
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
		if (NBFLCNHFEFM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NBFLCNHFEFM);
		}
		if (JKLFMOHICMO)
		{
			output.WriteRawTag(32);
			output.WriteBool(JKLFMOHICMO);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Reward);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		if (NBFLCNHFEFM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NBFLCNHFEFM);
		}
		if (JKLFMOHICMO)
		{
			num += 2;
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
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
	public void MergeFrom(PlanetFesGameBingoFlipScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NBFLCNHFEFM != 0)
		{
			NBFLCNHFEFM = other.NBFLCNHFEFM;
		}
		if (other.JKLFMOHICMO)
		{
			JKLFMOHICMO = other.JKLFMOHICMO;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new HLLCDBLCIPK();
			}
			Reward.MergeFrom(other.Reward);
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
			case 24u:
				NBFLCNHFEFM = input.ReadUInt32();
				break;
			case 32u:
				JKLFMOHICMO = input.ReadBool();
				break;
			case 66u:
				if (reward_ == null)
				{
					Reward = new HLLCDBLCIPK();
				}
				input.ReadMessage(Reward);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
