using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EHKEJEPNGMB : IMessage<EHKEJEPNGMB>, IMessage, IEquatable<EHKEJEPNGMB>, IDeepCloneable<EHKEJEPNGMB>, IBufferMessage
{
	private static readonly MessageParser<EHKEJEPNGMB> _parser = new MessageParser<EHKEJEPNGMB>(() => new EHKEJEPNGMB());

	private UnknownFieldSet _unknownFields;

	public const int NINNEKFGNLIFieldNumber = 1;

	private uint nINNEKFGNLI_;

	public const int NCFHGIBCEBGFieldNumber = 2;

	private uint nCFHGIBCEBG_;

	public const int FJHHJEDPHMAFieldNumber = 3;

	private uint fJHHJEDPHMA_;

	public const int GNCOPJNBCKIFieldNumber = 4;

	private long gNCOPJNBCKI_;

	public const int OFOMBFJEDKCFieldNumber = 5;

	private string oFOMBFJEDKC_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EHKEJEPNGMB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EHKEJEPNGMBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NINNEKFGNLI
	{
		get
		{
			return nINNEKFGNLI_;
		}
		set
		{
			nINNEKFGNLI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCFHGIBCEBG
	{
		get
		{
			return nCFHGIBCEBG_;
		}
		set
		{
			nCFHGIBCEBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FJHHJEDPHMA
	{
		get
		{
			return fJHHJEDPHMA_;
		}
		set
		{
			fJHHJEDPHMA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long GNCOPJNBCKI
	{
		get
		{
			return gNCOPJNBCKI_;
		}
		set
		{
			gNCOPJNBCKI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string OFOMBFJEDKC
	{
		get
		{
			return oFOMBFJEDKC_;
		}
		set
		{
			oFOMBFJEDKC_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EHKEJEPNGMB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EHKEJEPNGMB(EHKEJEPNGMB other)
		: this()
	{
		nINNEKFGNLI_ = other.nINNEKFGNLI_;
		nCFHGIBCEBG_ = other.nCFHGIBCEBG_;
		fJHHJEDPHMA_ = other.fJHHJEDPHMA_;
		gNCOPJNBCKI_ = other.gNCOPJNBCKI_;
		oFOMBFJEDKC_ = other.oFOMBFJEDKC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EHKEJEPNGMB Clone()
	{
		return new EHKEJEPNGMB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EHKEJEPNGMB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EHKEJEPNGMB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NINNEKFGNLI != other.NINNEKFGNLI)
		{
			return false;
		}
		if (NCFHGIBCEBG != other.NCFHGIBCEBG)
		{
			return false;
		}
		if (FJHHJEDPHMA != other.FJHHJEDPHMA)
		{
			return false;
		}
		if (GNCOPJNBCKI != other.GNCOPJNBCKI)
		{
			return false;
		}
		if (OFOMBFJEDKC != other.OFOMBFJEDKC)
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
		if (NINNEKFGNLI != 0)
		{
			num ^= NINNEKFGNLI.GetHashCode();
		}
		if (NCFHGIBCEBG != 0)
		{
			num ^= NCFHGIBCEBG.GetHashCode();
		}
		if (FJHHJEDPHMA != 0)
		{
			num ^= FJHHJEDPHMA.GetHashCode();
		}
		if (GNCOPJNBCKI != 0L)
		{
			num ^= GNCOPJNBCKI.GetHashCode();
		}
		if (OFOMBFJEDKC.Length != 0)
		{
			num ^= OFOMBFJEDKC.GetHashCode();
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
		if (NINNEKFGNLI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NINNEKFGNLI);
		}
		if (NCFHGIBCEBG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NCFHGIBCEBG);
		}
		if (FJHHJEDPHMA != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FJHHJEDPHMA);
		}
		if (GNCOPJNBCKI != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(GNCOPJNBCKI);
		}
		if (OFOMBFJEDKC.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(OFOMBFJEDKC);
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
		if (NINNEKFGNLI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NINNEKFGNLI);
		}
		if (NCFHGIBCEBG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCFHGIBCEBG);
		}
		if (FJHHJEDPHMA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FJHHJEDPHMA);
		}
		if (GNCOPJNBCKI != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(GNCOPJNBCKI);
		}
		if (OFOMBFJEDKC.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OFOMBFJEDKC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EHKEJEPNGMB other)
	{
		if (other != null)
		{
			if (other.NINNEKFGNLI != 0)
			{
				NINNEKFGNLI = other.NINNEKFGNLI;
			}
			if (other.NCFHGIBCEBG != 0)
			{
				NCFHGIBCEBG = other.NCFHGIBCEBG;
			}
			if (other.FJHHJEDPHMA != 0)
			{
				FJHHJEDPHMA = other.FJHHJEDPHMA;
			}
			if (other.GNCOPJNBCKI != 0L)
			{
				GNCOPJNBCKI = other.GNCOPJNBCKI;
			}
			if (other.OFOMBFJEDKC.Length != 0)
			{
				OFOMBFJEDKC = other.OFOMBFJEDKC;
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
				NINNEKFGNLI = input.ReadUInt32();
				break;
			case 16u:
				NCFHGIBCEBG = input.ReadUInt32();
				break;
			case 24u:
				FJHHJEDPHMA = input.ReadUInt32();
				break;
			case 32u:
				GNCOPJNBCKI = input.ReadInt64();
				break;
			case 42u:
				OFOMBFJEDKC = input.ReadString();
				break;
			}
		}
	}
}
