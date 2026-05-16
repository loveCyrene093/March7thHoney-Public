using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PKECJPJCONJ : IMessage<PKECJPJCONJ>, IMessage, IEquatable<PKECJPJCONJ>, IDeepCloneable<PKECJPJCONJ>, IBufferMessage
{
	private static readonly MessageParser<PKECJPJCONJ> _parser = new MessageParser<PKECJPJCONJ>(() => new PKECJPJCONJ());

	private UnknownFieldSet _unknownFields;

	public const int AEKJAAKCDKKFieldNumber = 6;

	private OOKGKMIMIID aEKJAAKCDKK_;

	public const int CBGOEHOAMHGFieldNumber = 9;

	private MFHOJCCILLC cBGOEHOAMHG_;

	public const int KDGIKCDGIGEFieldNumber = 10;

	private JPPHKCHDIJD kDGIKCDGIGE_;

	public const int DCFDDBIIMJPFieldNumber = 13;

	private KAONKHLDGPB dCFDDBIIMJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PKECJPJCONJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PKECJPJCONJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOKGKMIMIID AEKJAAKCDKK
	{
		get
		{
			return aEKJAAKCDKK_;
		}
		set
		{
			aEKJAAKCDKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFHOJCCILLC CBGOEHOAMHG
	{
		get
		{
			return cBGOEHOAMHG_;
		}
		set
		{
			cBGOEHOAMHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPPHKCHDIJD KDGIKCDGIGE
	{
		get
		{
			return kDGIKCDGIGE_;
		}
		set
		{
			kDGIKCDGIGE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAONKHLDGPB DCFDDBIIMJP
	{
		get
		{
			return dCFDDBIIMJP_;
		}
		set
		{
			dCFDDBIIMJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKECJPJCONJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKECJPJCONJ(PKECJPJCONJ other)
		: this()
	{
		aEKJAAKCDKK_ = ((other.aEKJAAKCDKK_ != null) ? other.aEKJAAKCDKK_.Clone() : null);
		cBGOEHOAMHG_ = ((other.cBGOEHOAMHG_ != null) ? other.cBGOEHOAMHG_.Clone() : null);
		kDGIKCDGIGE_ = ((other.kDGIKCDGIGE_ != null) ? other.kDGIKCDGIGE_.Clone() : null);
		dCFDDBIIMJP_ = ((other.dCFDDBIIMJP_ != null) ? other.dCFDDBIIMJP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKECJPJCONJ Clone()
	{
		return new PKECJPJCONJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PKECJPJCONJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PKECJPJCONJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AEKJAAKCDKK, other.AEKJAAKCDKK))
		{
			return false;
		}
		if (!object.Equals(CBGOEHOAMHG, other.CBGOEHOAMHG))
		{
			return false;
		}
		if (!object.Equals(KDGIKCDGIGE, other.KDGIKCDGIGE))
		{
			return false;
		}
		if (!object.Equals(DCFDDBIIMJP, other.DCFDDBIIMJP))
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
		if (aEKJAAKCDKK_ != null)
		{
			num ^= AEKJAAKCDKK.GetHashCode();
		}
		if (cBGOEHOAMHG_ != null)
		{
			num ^= CBGOEHOAMHG.GetHashCode();
		}
		if (kDGIKCDGIGE_ != null)
		{
			num ^= KDGIKCDGIGE.GetHashCode();
		}
		if (dCFDDBIIMJP_ != null)
		{
			num ^= DCFDDBIIMJP.GetHashCode();
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
		if (aEKJAAKCDKK_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AEKJAAKCDKK);
		}
		if (cBGOEHOAMHG_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(CBGOEHOAMHG);
		}
		if (kDGIKCDGIGE_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(KDGIKCDGIGE);
		}
		if (dCFDDBIIMJP_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(DCFDDBIIMJP);
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
		if (aEKJAAKCDKK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AEKJAAKCDKK);
		}
		if (cBGOEHOAMHG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CBGOEHOAMHG);
		}
		if (kDGIKCDGIGE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KDGIKCDGIGE);
		}
		if (dCFDDBIIMJP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DCFDDBIIMJP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PKECJPJCONJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aEKJAAKCDKK_ != null)
		{
			if (aEKJAAKCDKK_ == null)
			{
				AEKJAAKCDKK = new OOKGKMIMIID();
			}
			AEKJAAKCDKK.MergeFrom(other.AEKJAAKCDKK);
		}
		if (other.cBGOEHOAMHG_ != null)
		{
			if (cBGOEHOAMHG_ == null)
			{
				CBGOEHOAMHG = new MFHOJCCILLC();
			}
			CBGOEHOAMHG.MergeFrom(other.CBGOEHOAMHG);
		}
		if (other.kDGIKCDGIGE_ != null)
		{
			if (kDGIKCDGIGE_ == null)
			{
				KDGIKCDGIGE = new JPPHKCHDIJD();
			}
			KDGIKCDGIGE.MergeFrom(other.KDGIKCDGIGE);
		}
		if (other.dCFDDBIIMJP_ != null)
		{
			if (dCFDDBIIMJP_ == null)
			{
				DCFDDBIIMJP = new KAONKHLDGPB();
			}
			DCFDDBIIMJP.MergeFrom(other.DCFDDBIIMJP);
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
			case 50u:
				if (aEKJAAKCDKK_ == null)
				{
					AEKJAAKCDKK = new OOKGKMIMIID();
				}
				input.ReadMessage(AEKJAAKCDKK);
				break;
			case 74u:
				if (cBGOEHOAMHG_ == null)
				{
					CBGOEHOAMHG = new MFHOJCCILLC();
				}
				input.ReadMessage(CBGOEHOAMHG);
				break;
			case 82u:
				if (kDGIKCDGIGE_ == null)
				{
					KDGIKCDGIGE = new JPPHKCHDIJD();
				}
				input.ReadMessage(KDGIKCDGIGE);
				break;
			case 106u:
				if (dCFDDBIIMJP_ == null)
				{
					DCFDDBIIMJP = new KAONKHLDGPB();
				}
				input.ReadMessage(DCFDDBIIMJP);
				break;
			}
		}
	}
}
