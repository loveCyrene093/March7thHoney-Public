using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EDGGKGPFLNP : IMessage<EDGGKGPFLNP>, IMessage, IEquatable<EDGGKGPFLNP>, IDeepCloneable<EDGGKGPFLNP>, IBufferMessage
{
	private static readonly MessageParser<EDGGKGPFLNP> _parser = new MessageParser<EDGGKGPFLNP>(() => new EDGGKGPFLNP());

	private UnknownFieldSet _unknownFields;

	public const int KOPHOHJFCCKFieldNumber = 2;

	private uint kOPHOHJFCCK_;

	public const int JLCEEEBNEOLFieldNumber = 4;

	private static readonly FieldCodec<NLJLHPEOIOC> _repeated_jLCEEEBNEOL_codec = FieldCodec.ForMessage(34u, NLJLHPEOIOC.Parser);

	private readonly RepeatedField<NLJLHPEOIOC> jLCEEEBNEOL_ = new RepeatedField<NLJLHPEOIOC>();

	public const int NCJHFFDDHLIFieldNumber = 7;

	private OMNJNKNMLKL nCJHFFDDHLI_;

	public const int MJGMDMFHKBIFieldNumber = 8;

	private uint mJGMDMFHKBI_;

	public const int NFJKKKJIIPFFieldNumber = 12;

	private uint nFJKKKJIIPF_;

	public const int HGIJNGPMCDHFieldNumber = 13;

	private uint hGIJNGPMCDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EDGGKGPFLNP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EDGGKGPFLNPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KOPHOHJFCCK
	{
		get
		{
			return kOPHOHJFCCK_;
		}
		set
		{
			kOPHOHJFCCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NLJLHPEOIOC> JLCEEEBNEOL => jLCEEEBNEOL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMNJNKNMLKL NCJHFFDDHLI
	{
		get
		{
			return nCJHFFDDHLI_;
		}
		set
		{
			nCJHFFDDHLI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MJGMDMFHKBI
	{
		get
		{
			return mJGMDMFHKBI_;
		}
		set
		{
			mJGMDMFHKBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NFJKKKJIIPF
	{
		get
		{
			return nFJKKKJIIPF_;
		}
		set
		{
			nFJKKKJIIPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HGIJNGPMCDH
	{
		get
		{
			return hGIJNGPMCDH_;
		}
		set
		{
			hGIJNGPMCDH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDGGKGPFLNP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDGGKGPFLNP(EDGGKGPFLNP other)
		: this()
	{
		kOPHOHJFCCK_ = other.kOPHOHJFCCK_;
		jLCEEEBNEOL_ = other.jLCEEEBNEOL_.Clone();
		nCJHFFDDHLI_ = ((other.nCJHFFDDHLI_ != null) ? other.nCJHFFDDHLI_.Clone() : null);
		mJGMDMFHKBI_ = other.mJGMDMFHKBI_;
		nFJKKKJIIPF_ = other.nFJKKKJIIPF_;
		hGIJNGPMCDH_ = other.hGIJNGPMCDH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EDGGKGPFLNP Clone()
	{
		return new EDGGKGPFLNP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EDGGKGPFLNP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EDGGKGPFLNP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KOPHOHJFCCK != other.KOPHOHJFCCK)
		{
			return false;
		}
		if (!jLCEEEBNEOL_.Equals(other.jLCEEEBNEOL_))
		{
			return false;
		}
		if (!object.Equals(NCJHFFDDHLI, other.NCJHFFDDHLI))
		{
			return false;
		}
		if (MJGMDMFHKBI != other.MJGMDMFHKBI)
		{
			return false;
		}
		if (NFJKKKJIIPF != other.NFJKKKJIIPF)
		{
			return false;
		}
		if (HGIJNGPMCDH != other.HGIJNGPMCDH)
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
		if (KOPHOHJFCCK != 0)
		{
			num ^= KOPHOHJFCCK.GetHashCode();
		}
		num ^= jLCEEEBNEOL_.GetHashCode();
		if (nCJHFFDDHLI_ != null)
		{
			num ^= NCJHFFDDHLI.GetHashCode();
		}
		if (MJGMDMFHKBI != 0)
		{
			num ^= MJGMDMFHKBI.GetHashCode();
		}
		if (NFJKKKJIIPF != 0)
		{
			num ^= NFJKKKJIIPF.GetHashCode();
		}
		if (HGIJNGPMCDH != 0)
		{
			num ^= HGIJNGPMCDH.GetHashCode();
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
		if (KOPHOHJFCCK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(KOPHOHJFCCK);
		}
		jLCEEEBNEOL_.WriteTo(ref output, _repeated_jLCEEEBNEOL_codec);
		if (nCJHFFDDHLI_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(NCJHFFDDHLI);
		}
		if (MJGMDMFHKBI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MJGMDMFHKBI);
		}
		if (NFJKKKJIIPF != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NFJKKKJIIPF);
		}
		if (HGIJNGPMCDH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HGIJNGPMCDH);
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
		if (KOPHOHJFCCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KOPHOHJFCCK);
		}
		num += jLCEEEBNEOL_.CalculateSize(_repeated_jLCEEEBNEOL_codec);
		if (nCJHFFDDHLI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NCJHFFDDHLI);
		}
		if (MJGMDMFHKBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MJGMDMFHKBI);
		}
		if (NFJKKKJIIPF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NFJKKKJIIPF);
		}
		if (HGIJNGPMCDH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HGIJNGPMCDH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EDGGKGPFLNP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KOPHOHJFCCK != 0)
		{
			KOPHOHJFCCK = other.KOPHOHJFCCK;
		}
		jLCEEEBNEOL_.Add(other.jLCEEEBNEOL_);
		if (other.nCJHFFDDHLI_ != null)
		{
			if (nCJHFFDDHLI_ == null)
			{
				NCJHFFDDHLI = new OMNJNKNMLKL();
			}
			NCJHFFDDHLI.MergeFrom(other.NCJHFFDDHLI);
		}
		if (other.MJGMDMFHKBI != 0)
		{
			MJGMDMFHKBI = other.MJGMDMFHKBI;
		}
		if (other.NFJKKKJIIPF != 0)
		{
			NFJKKKJIIPF = other.NFJKKKJIIPF;
		}
		if (other.HGIJNGPMCDH != 0)
		{
			HGIJNGPMCDH = other.HGIJNGPMCDH;
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
			case 16u:
				KOPHOHJFCCK = input.ReadUInt32();
				break;
			case 34u:
				jLCEEEBNEOL_.AddEntriesFrom(ref input, _repeated_jLCEEEBNEOL_codec);
				break;
			case 58u:
				if (nCJHFFDDHLI_ == null)
				{
					NCJHFFDDHLI = new OMNJNKNMLKL();
				}
				input.ReadMessage(NCJHFFDDHLI);
				break;
			case 64u:
				MJGMDMFHKBI = input.ReadUInt32();
				break;
			case 96u:
				NFJKKKJIIPF = input.ReadUInt32();
				break;
			case 104u:
				HGIJNGPMCDH = input.ReadUInt32();
				break;
			}
		}
	}
}
