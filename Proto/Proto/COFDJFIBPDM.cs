using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class COFDJFIBPDM : IMessage<COFDJFIBPDM>, IMessage, IEquatable<COFDJFIBPDM>, IDeepCloneable<COFDJFIBPDM>, IBufferMessage
{
	public enum BGMDKLOBICMOneofCase
	{
		None = 0,
		BPHAEFAJJKO = 3,
		GBHJGILIJMP = 13,
		BPFCEJKNCDP = 14
	}

	private static readonly MessageParser<COFDJFIBPDM> _parser = new MessageParser<COFDJFIBPDM>(() => new COFDJFIBPDM());

	private UnknownFieldSet _unknownFields;

	public const int BPHAEFAJJKOFieldNumber = 3;

	public const int GBHJGILIJMPFieldNumber = 13;

	public const int BPFCEJKNCDPFieldNumber = 14;

	private object bGMDKLOBICM_;

	private BGMDKLOBICMOneofCase bGMDKLOBICMCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<COFDJFIBPDM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => COFDJFIBPDMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBBEHBNAAFI BPHAEFAJJKO
	{
		get
		{
			if (bGMDKLOBICMCase_ != BGMDKLOBICMOneofCase.BPHAEFAJJKO)
			{
				return null;
			}
			return (NBBEHBNAAFI)bGMDKLOBICM_;
		}
		set
		{
			bGMDKLOBICM_ = value;
			bGMDKLOBICMCase_ = ((value != null) ? BGMDKLOBICMOneofCase.BPHAEFAJJKO : BGMDKLOBICMOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGLMEMPJELD GBHJGILIJMP
	{
		get
		{
			if (bGMDKLOBICMCase_ != BGMDKLOBICMOneofCase.GBHJGILIJMP)
			{
				return null;
			}
			return (MGLMEMPJELD)bGMDKLOBICM_;
		}
		set
		{
			bGMDKLOBICM_ = value;
			bGMDKLOBICMCase_ = ((value != null) ? BGMDKLOBICMOneofCase.GBHJGILIJMP : BGMDKLOBICMOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGLAEKCFNO BPFCEJKNCDP
	{
		get
		{
			if (bGMDKLOBICMCase_ != BGMDKLOBICMOneofCase.BPFCEJKNCDP)
			{
				return null;
			}
			return (AKGLAEKCFNO)bGMDKLOBICM_;
		}
		set
		{
			bGMDKLOBICM_ = value;
			bGMDKLOBICMCase_ = ((value != null) ? BGMDKLOBICMOneofCase.BPFCEJKNCDP : BGMDKLOBICMOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGMDKLOBICMOneofCase BGMDKLOBICMCase => bGMDKLOBICMCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COFDJFIBPDM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COFDJFIBPDM(COFDJFIBPDM other)
		: this()
	{
		switch (other.BGMDKLOBICMCase)
		{
		case BGMDKLOBICMOneofCase.BPHAEFAJJKO:
			BPHAEFAJJKO = other.BPHAEFAJJKO.Clone();
			break;
		case BGMDKLOBICMOneofCase.GBHJGILIJMP:
			GBHJGILIJMP = other.GBHJGILIJMP.Clone();
			break;
		case BGMDKLOBICMOneofCase.BPFCEJKNCDP:
			BPFCEJKNCDP = other.BPFCEJKNCDP.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COFDJFIBPDM Clone()
	{
		return new COFDJFIBPDM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBGMDKLOBICM()
	{
		bGMDKLOBICMCase_ = BGMDKLOBICMOneofCase.None;
		bGMDKLOBICM_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as COFDJFIBPDM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(COFDJFIBPDM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BPHAEFAJJKO, other.BPHAEFAJJKO))
		{
			return false;
		}
		if (!object.Equals(GBHJGILIJMP, other.GBHJGILIJMP))
		{
			return false;
		}
		if (!object.Equals(BPFCEJKNCDP, other.BPFCEJKNCDP))
		{
			return false;
		}
		if (BGMDKLOBICMCase != other.BGMDKLOBICMCase)
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
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.BPHAEFAJJKO)
		{
			num ^= BPHAEFAJJKO.GetHashCode();
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.GBHJGILIJMP)
		{
			num ^= GBHJGILIJMP.GetHashCode();
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.BPFCEJKNCDP)
		{
			num ^= BPFCEJKNCDP.GetHashCode();
		}
		num ^= (int)bGMDKLOBICMCase_;
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
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.BPHAEFAJJKO)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BPHAEFAJJKO);
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.GBHJGILIJMP)
		{
			output.WriteRawTag(106);
			output.WriteMessage(GBHJGILIJMP);
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.BPFCEJKNCDP)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BPFCEJKNCDP);
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
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.BPHAEFAJJKO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPHAEFAJJKO);
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.GBHJGILIJMP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GBHJGILIJMP);
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.BPFCEJKNCDP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPFCEJKNCDP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(COFDJFIBPDM other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BGMDKLOBICMCase)
		{
		case BGMDKLOBICMOneofCase.BPHAEFAJJKO:
			if (BPHAEFAJJKO == null)
			{
				BPHAEFAJJKO = new NBBEHBNAAFI();
			}
			BPHAEFAJJKO.MergeFrom(other.BPHAEFAJJKO);
			break;
		case BGMDKLOBICMOneofCase.GBHJGILIJMP:
			if (GBHJGILIJMP == null)
			{
				GBHJGILIJMP = new MGLMEMPJELD();
			}
			GBHJGILIJMP.MergeFrom(other.GBHJGILIJMP);
			break;
		case BGMDKLOBICMOneofCase.BPFCEJKNCDP:
			if (BPFCEJKNCDP == null)
			{
				BPFCEJKNCDP = new AKGLAEKCFNO();
			}
			BPFCEJKNCDP.MergeFrom(other.BPFCEJKNCDP);
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
			case 26u:
			{
				NBBEHBNAAFI nBBEHBNAAFI = new NBBEHBNAAFI();
				if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.BPHAEFAJJKO)
				{
					nBBEHBNAAFI.MergeFrom(BPHAEFAJJKO);
				}
				input.ReadMessage(nBBEHBNAAFI);
				BPHAEFAJJKO = nBBEHBNAAFI;
				break;
			}
			case 106u:
			{
				MGLMEMPJELD mGLMEMPJELD = new MGLMEMPJELD();
				if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.GBHJGILIJMP)
				{
					mGLMEMPJELD.MergeFrom(GBHJGILIJMP);
				}
				input.ReadMessage(mGLMEMPJELD);
				GBHJGILIJMP = mGLMEMPJELD;
				break;
			}
			case 114u:
			{
				AKGLAEKCFNO aKGLAEKCFNO = new AKGLAEKCFNO();
				if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.BPFCEJKNCDP)
				{
					aKGLAEKCFNO.MergeFrom(BPFCEJKNCDP);
				}
				input.ReadMessage(aKGLAEKCFNO);
				BPFCEJKNCDP = aKGLAEKCFNO;
				break;
			}
			}
		}
	}
}
