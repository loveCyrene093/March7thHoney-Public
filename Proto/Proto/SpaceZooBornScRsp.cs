using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpaceZooBornScRsp : IMessage<SpaceZooBornScRsp>, IMessage, IEquatable<SpaceZooBornScRsp>, IDeepCloneable<SpaceZooBornScRsp>, IBufferMessage
{
	private static readonly MessageParser<SpaceZooBornScRsp> _parser = new MessageParser<SpaceZooBornScRsp>(() => new SpaceZooBornScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BFALLCGIPOGFieldNumber = 3;

	private bool bFALLCGIPOG_;

	public const int DHHMBFHKLJGFieldNumber = 4;

	private static readonly FieldCodec<DMNDJBPGEKG> _repeated_dHHMBFHKLJG_codec = FieldCodec.ForMessage(34u, DMNDJBPGEKG.Parser);

	private readonly RepeatedField<DMNDJBPGEKG> dHHMBFHKLJG_ = new RepeatedField<DMNDJBPGEKG>();

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int DPPHNDCODMGFieldNumber = 11;

	private LKJMLPJEPGG dPPHNDCODMG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpaceZooBornScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpaceZooBornScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BFALLCGIPOG
	{
		get
		{
			return bFALLCGIPOG_;
		}
		set
		{
			bFALLCGIPOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DMNDJBPGEKG> DHHMBFHKLJG => dHHMBFHKLJG_;

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
	public LKJMLPJEPGG DPPHNDCODMG
	{
		get
		{
			return dPPHNDCODMG_;
		}
		set
		{
			dPPHNDCODMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooBornScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooBornScRsp(SpaceZooBornScRsp other)
		: this()
	{
		bFALLCGIPOG_ = other.bFALLCGIPOG_;
		dHHMBFHKLJG_ = other.dHHMBFHKLJG_.Clone();
		retcode_ = other.retcode_;
		dPPHNDCODMG_ = ((other.dPPHNDCODMG_ != null) ? other.dPPHNDCODMG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooBornScRsp Clone()
	{
		return new SpaceZooBornScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpaceZooBornScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpaceZooBornScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BFALLCGIPOG != other.BFALLCGIPOG)
		{
			return false;
		}
		if (!dHHMBFHKLJG_.Equals(other.dHHMBFHKLJG_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(DPPHNDCODMG, other.DPPHNDCODMG))
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
		if (BFALLCGIPOG)
		{
			num ^= BFALLCGIPOG.GetHashCode();
		}
		num ^= dHHMBFHKLJG_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (dPPHNDCODMG_ != null)
		{
			num ^= DPPHNDCODMG.GetHashCode();
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
		if (BFALLCGIPOG)
		{
			output.WriteRawTag(24);
			output.WriteBool(BFALLCGIPOG);
		}
		dHHMBFHKLJG_.WriteTo(ref output, _repeated_dHHMBFHKLJG_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (dPPHNDCODMG_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DPPHNDCODMG);
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
		if (BFALLCGIPOG)
		{
			num += 2;
		}
		num += dHHMBFHKLJG_.CalculateSize(_repeated_dHHMBFHKLJG_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (dPPHNDCODMG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DPPHNDCODMG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpaceZooBornScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BFALLCGIPOG)
		{
			BFALLCGIPOG = other.BFALLCGIPOG;
		}
		dHHMBFHKLJG_.Add(other.dHHMBFHKLJG_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.dPPHNDCODMG_ != null)
		{
			if (dPPHNDCODMG_ == null)
			{
				DPPHNDCODMG = new LKJMLPJEPGG();
			}
			DPPHNDCODMG.MergeFrom(other.DPPHNDCODMG);
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
				BFALLCGIPOG = input.ReadBool();
				break;
			case 34u:
				dHHMBFHKLJG_.AddEntriesFrom(ref input, _repeated_dHHMBFHKLJG_codec);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (dPPHNDCODMG_ == null)
				{
					DPPHNDCODMG = new LKJMLPJEPGG();
				}
				input.ReadMessage(DPPHNDCODMG);
				break;
			}
		}
	}
}
