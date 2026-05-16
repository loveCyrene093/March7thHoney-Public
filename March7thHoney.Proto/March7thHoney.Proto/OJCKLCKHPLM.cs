using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OJCKLCKHPLM : IMessage<OJCKLCKHPLM>, IMessage, IEquatable<OJCKLCKHPLM>, IDeepCloneable<OJCKLCKHPLM>, IBufferMessage
{
	public enum FNJJNAOCOIIOneofCase
	{
		None = 0,
		PBPDBJBLPGL = 1,
		EMENFKABDEK = 12
	}

	private static readonly MessageParser<OJCKLCKHPLM> _parser = new MessageParser<OJCKLCKHPLM>(() => new OJCKLCKHPLM());

	private UnknownFieldSet _unknownFields;

	public const int PBPDBJBLPGLFieldNumber = 1;

	public const int EMENFKABDEKFieldNumber = 12;

	private object fNJJNAOCOII_;

	private FNJJNAOCOIIOneofCase fNJJNAOCOIICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OJCKLCKHPLM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OJCKLCKHPLMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PBPDBJBLPGL
	{
		get
		{
			if (!HasPBPDBJBLPGL)
			{
				return 0u;
			}
			return (uint)fNJJNAOCOII_;
		}
		set
		{
			fNJJNAOCOII_ = value;
			fNJJNAOCOIICase_ = FNJJNAOCOIIOneofCase.PBPDBJBLPGL;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPBPDBJBLPGL => fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.PBPDBJBLPGL;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOIKCKDHPGC EMENFKABDEK
	{
		get
		{
			if (fNJJNAOCOIICase_ != FNJJNAOCOIIOneofCase.EMENFKABDEK)
			{
				return null;
			}
			return (HOIKCKDHPGC)fNJJNAOCOII_;
		}
		set
		{
			fNJJNAOCOII_ = value;
			fNJJNAOCOIICase_ = ((value != null) ? FNJJNAOCOIIOneofCase.EMENFKABDEK : FNJJNAOCOIIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNJJNAOCOIIOneofCase FNJJNAOCOIICase => fNJJNAOCOIICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJCKLCKHPLM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJCKLCKHPLM(OJCKLCKHPLM other)
		: this()
	{
		switch (other.FNJJNAOCOIICase)
		{
		case FNJJNAOCOIIOneofCase.PBPDBJBLPGL:
			PBPDBJBLPGL = other.PBPDBJBLPGL;
			break;
		case FNJJNAOCOIIOneofCase.EMENFKABDEK:
			EMENFKABDEK = other.EMENFKABDEK.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJCKLCKHPLM Clone()
	{
		return new OJCKLCKHPLM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPBPDBJBLPGL()
	{
		if (HasPBPDBJBLPGL)
		{
			ClearFNJJNAOCOII();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFNJJNAOCOII()
	{
		fNJJNAOCOIICase_ = FNJJNAOCOIIOneofCase.None;
		fNJJNAOCOII_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OJCKLCKHPLM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OJCKLCKHPLM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PBPDBJBLPGL != other.PBPDBJBLPGL)
		{
			return false;
		}
		if (!object.Equals(EMENFKABDEK, other.EMENFKABDEK))
		{
			return false;
		}
		if (FNJJNAOCOIICase != other.FNJJNAOCOIICase)
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
		if (HasPBPDBJBLPGL)
		{
			num ^= PBPDBJBLPGL.GetHashCode();
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.EMENFKABDEK)
		{
			num ^= EMENFKABDEK.GetHashCode();
		}
		num ^= (int)fNJJNAOCOIICase_;
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
		if (HasPBPDBJBLPGL)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PBPDBJBLPGL);
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.EMENFKABDEK)
		{
			output.WriteRawTag(98);
			output.WriteMessage(EMENFKABDEK);
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
		if (HasPBPDBJBLPGL)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PBPDBJBLPGL);
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.EMENFKABDEK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EMENFKABDEK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OJCKLCKHPLM other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.FNJJNAOCOIICase)
		{
		case FNJJNAOCOIIOneofCase.PBPDBJBLPGL:
			PBPDBJBLPGL = other.PBPDBJBLPGL;
			break;
		case FNJJNAOCOIIOneofCase.EMENFKABDEK:
			if (EMENFKABDEK == null)
			{
				EMENFKABDEK = new HOIKCKDHPGC();
			}
			EMENFKABDEK.MergeFrom(other.EMENFKABDEK);
			break;
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
				PBPDBJBLPGL = input.ReadUInt32();
				break;
			case 98u:
			{
				HOIKCKDHPGC hOIKCKDHPGC = new HOIKCKDHPGC();
				if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.EMENFKABDEK)
				{
					hOIKCKDHPGC.MergeFrom(EMENFKABDEK);
				}
				input.ReadMessage(hOIKCKDHPGC);
				EMENFKABDEK = hOIKCKDHPGC;
				break;
			}
			}
		}
	}
}
