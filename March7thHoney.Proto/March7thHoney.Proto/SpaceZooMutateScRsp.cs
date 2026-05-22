using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpaceZooMutateScRsp : IMessage<SpaceZooMutateScRsp>, IMessage, IEquatable<SpaceZooMutateScRsp>, IDeepCloneable<SpaceZooMutateScRsp>, IBufferMessage
{
	private static readonly MessageParser<SpaceZooMutateScRsp> _parser = new MessageParser<SpaceZooMutateScRsp>(() => new SpaceZooMutateScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BFALLCGIPOGFieldNumber = 1;

	private bool bFALLCGIPOG_;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int DHHMBFHKLJGFieldNumber = 11;

	private static readonly FieldCodec<DMNDJBPGEKG> _repeated_dHHMBFHKLJG_codec = FieldCodec.ForMessage(90u, DMNDJBPGEKG.Parser);

	private readonly RepeatedField<DMNDJBPGEKG> dHHMBFHKLJG_ = new RepeatedField<DMNDJBPGEKG>();

	public const int EAMEJGFGNPAFieldNumber = 14;

	private LKJMLPJEPGG eAMEJGFGNPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpaceZooMutateScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpaceZooMutateScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<DMNDJBPGEKG> DHHMBFHKLJG => dHHMBFHKLJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKJMLPJEPGG EAMEJGFGNPA
	{
		get
		{
			return eAMEJGFGNPA_;
		}
		set
		{
			eAMEJGFGNPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooMutateScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooMutateScRsp(SpaceZooMutateScRsp other)
		: this()
	{
		bFALLCGIPOG_ = other.bFALLCGIPOG_;
		retcode_ = other.retcode_;
		dHHMBFHKLJG_ = other.dHHMBFHKLJG_.Clone();
		eAMEJGFGNPA_ = ((other.eAMEJGFGNPA_ != null) ? other.eAMEJGFGNPA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooMutateScRsp Clone()
	{
		return new SpaceZooMutateScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpaceZooMutateScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpaceZooMutateScRsp other)
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
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!dHHMBFHKLJG_.Equals(other.dHHMBFHKLJG_))
		{
			return false;
		}
		if (!object.Equals(EAMEJGFGNPA, other.EAMEJGFGNPA))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= dHHMBFHKLJG_.GetHashCode();
		if (eAMEJGFGNPA_ != null)
		{
			num ^= EAMEJGFGNPA.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteBool(BFALLCGIPOG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		dHHMBFHKLJG_.WriteTo(ref output, _repeated_dHHMBFHKLJG_codec);
		if (eAMEJGFGNPA_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(EAMEJGFGNPA);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += dHHMBFHKLJG_.CalculateSize(_repeated_dHHMBFHKLJG_codec);
		if (eAMEJGFGNPA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EAMEJGFGNPA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpaceZooMutateScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BFALLCGIPOG)
		{
			BFALLCGIPOG = other.BFALLCGIPOG;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		dHHMBFHKLJG_.Add(other.dHHMBFHKLJG_);
		if (other.eAMEJGFGNPA_ != null)
		{
			if (eAMEJGFGNPA_ == null)
			{
				EAMEJGFGNPA = new LKJMLPJEPGG();
			}
			EAMEJGFGNPA.MergeFrom(other.EAMEJGFGNPA);
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
			case 8u:
				BFALLCGIPOG = input.ReadBool();
				break;
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				dHHMBFHKLJG_.AddEntriesFrom(ref input, _repeated_dHHMBFHKLJG_codec);
				break;
			case 114u:
				if (eAMEJGFGNPA_ == null)
				{
					EAMEJGFGNPA = new LKJMLPJEPGG();
				}
				input.ReadMessage(EAMEJGFGNPA);
				break;
			}
		}
	}
}
