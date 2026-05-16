using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LOLKDKOCLLO : IMessage<LOLKDKOCLLO>, IMessage, IEquatable<LOLKDKOCLLO>, IDeepCloneable<LOLKDKOCLLO>, IBufferMessage
{
	private static readonly MessageParser<LOLKDKOCLLO> _parser = new MessageParser<LOLKDKOCLLO>(() => new LOLKDKOCLLO());

	private UnknownFieldSet _unknownFields;

	public const int JJGLBPGNJMLFieldNumber = 1;

	private MKEINLFOAEA jJGLBPGNJML_;

	public const int NKFNEGIDKNKFieldNumber = 2;

	private MKEINLFOAEA nKFNEGIDKNK_;

	public const int GBMBBLNEGCIFieldNumber = 3;

	private MKEINLFOAEA gBMBBLNEGCI_;

	public const int BOMEGHGNIKFFieldNumber = 4;

	private uint bOMEGHGNIKF_;

	public const int HCBGLJHAGAEFieldNumber = 5;

	private uint hCBGLJHAGAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LOLKDKOCLLO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LOLKDKOCLLOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKEINLFOAEA JJGLBPGNJML
	{
		get
		{
			return jJGLBPGNJML_;
		}
		set
		{
			jJGLBPGNJML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKEINLFOAEA NKFNEGIDKNK
	{
		get
		{
			return nKFNEGIDKNK_;
		}
		set
		{
			nKFNEGIDKNK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKEINLFOAEA GBMBBLNEGCI
	{
		get
		{
			return gBMBBLNEGCI_;
		}
		set
		{
			gBMBBLNEGCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BOMEGHGNIKF
	{
		get
		{
			return bOMEGHGNIKF_;
		}
		set
		{
			bOMEGHGNIKF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCBGLJHAGAE
	{
		get
		{
			return hCBGLJHAGAE_;
		}
		set
		{
			hCBGLJHAGAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOLKDKOCLLO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOLKDKOCLLO(LOLKDKOCLLO other)
		: this()
	{
		jJGLBPGNJML_ = ((other.jJGLBPGNJML_ != null) ? other.jJGLBPGNJML_.Clone() : null);
		nKFNEGIDKNK_ = ((other.nKFNEGIDKNK_ != null) ? other.nKFNEGIDKNK_.Clone() : null);
		gBMBBLNEGCI_ = ((other.gBMBBLNEGCI_ != null) ? other.gBMBBLNEGCI_.Clone() : null);
		bOMEGHGNIKF_ = other.bOMEGHGNIKF_;
		hCBGLJHAGAE_ = other.hCBGLJHAGAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOLKDKOCLLO Clone()
	{
		return new LOLKDKOCLLO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LOLKDKOCLLO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LOLKDKOCLLO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JJGLBPGNJML, other.JJGLBPGNJML))
		{
			return false;
		}
		if (!object.Equals(NKFNEGIDKNK, other.NKFNEGIDKNK))
		{
			return false;
		}
		if (!object.Equals(GBMBBLNEGCI, other.GBMBBLNEGCI))
		{
			return false;
		}
		if (BOMEGHGNIKF != other.BOMEGHGNIKF)
		{
			return false;
		}
		if (HCBGLJHAGAE != other.HCBGLJHAGAE)
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
		if (jJGLBPGNJML_ != null)
		{
			num ^= JJGLBPGNJML.GetHashCode();
		}
		if (nKFNEGIDKNK_ != null)
		{
			num ^= NKFNEGIDKNK.GetHashCode();
		}
		if (gBMBBLNEGCI_ != null)
		{
			num ^= GBMBBLNEGCI.GetHashCode();
		}
		if (BOMEGHGNIKF != 0)
		{
			num ^= BOMEGHGNIKF.GetHashCode();
		}
		if (HCBGLJHAGAE != 0)
		{
			num ^= HCBGLJHAGAE.GetHashCode();
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
		if (jJGLBPGNJML_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(JJGLBPGNJML);
		}
		if (nKFNEGIDKNK_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(NKFNEGIDKNK);
		}
		if (gBMBBLNEGCI_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(GBMBBLNEGCI);
		}
		if (BOMEGHGNIKF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BOMEGHGNIKF);
		}
		if (HCBGLJHAGAE != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HCBGLJHAGAE);
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
		if (jJGLBPGNJML_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JJGLBPGNJML);
		}
		if (nKFNEGIDKNK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NKFNEGIDKNK);
		}
		if (gBMBBLNEGCI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GBMBBLNEGCI);
		}
		if (BOMEGHGNIKF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BOMEGHGNIKF);
		}
		if (HCBGLJHAGAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCBGLJHAGAE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LOLKDKOCLLO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jJGLBPGNJML_ != null)
		{
			if (jJGLBPGNJML_ == null)
			{
				JJGLBPGNJML = new MKEINLFOAEA();
			}
			JJGLBPGNJML.MergeFrom(other.JJGLBPGNJML);
		}
		if (other.nKFNEGIDKNK_ != null)
		{
			if (nKFNEGIDKNK_ == null)
			{
				NKFNEGIDKNK = new MKEINLFOAEA();
			}
			NKFNEGIDKNK.MergeFrom(other.NKFNEGIDKNK);
		}
		if (other.gBMBBLNEGCI_ != null)
		{
			if (gBMBBLNEGCI_ == null)
			{
				GBMBBLNEGCI = new MKEINLFOAEA();
			}
			GBMBBLNEGCI.MergeFrom(other.GBMBBLNEGCI);
		}
		if (other.BOMEGHGNIKF != 0)
		{
			BOMEGHGNIKF = other.BOMEGHGNIKF;
		}
		if (other.HCBGLJHAGAE != 0)
		{
			HCBGLJHAGAE = other.HCBGLJHAGAE;
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
			case 10u:
				if (jJGLBPGNJML_ == null)
				{
					JJGLBPGNJML = new MKEINLFOAEA();
				}
				input.ReadMessage(JJGLBPGNJML);
				break;
			case 18u:
				if (nKFNEGIDKNK_ == null)
				{
					NKFNEGIDKNK = new MKEINLFOAEA();
				}
				input.ReadMessage(NKFNEGIDKNK);
				break;
			case 26u:
				if (gBMBBLNEGCI_ == null)
				{
					GBMBBLNEGCI = new MKEINLFOAEA();
				}
				input.ReadMessage(GBMBBLNEGCI);
				break;
			case 32u:
				BOMEGHGNIKF = input.ReadUInt32();
				break;
			case 40u:
				HCBGLJHAGAE = input.ReadUInt32();
				break;
			}
		}
	}
}
