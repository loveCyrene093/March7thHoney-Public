using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GPPGPMEDJEF : IMessage<GPPGPMEDJEF>, IMessage, IEquatable<GPPGPMEDJEF>, IDeepCloneable<GPPGPMEDJEF>, IBufferMessage
{
	private static readonly MessageParser<GPPGPMEDJEF> _parser = new MessageParser<GPPGPMEDJEF>(() => new GPPGPMEDJEF());

	private UnknownFieldSet _unknownFields;

	public const int JFJPDEPOFMOFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_jFJPDEPOFMO_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> jFJPDEPOFMO_ = new RepeatedField<uint>();

	public const int KGEBJNHOLCNFieldNumber = 2;

	private BFPIBIEGJGJ kGEBJNHOLCN_;

	public const int FNLDFGLGEOAFieldNumber = 8;

	private ItemList fNLDFGLGEOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GPPGPMEDJEF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GPPGPMEDJEFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JFJPDEPOFMO => jFJPDEPOFMO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFPIBIEGJGJ KGEBJNHOLCN
	{
		get
		{
			return kGEBJNHOLCN_;
		}
		set
		{
			kGEBJNHOLCN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList FNLDFGLGEOA
	{
		get
		{
			return fNLDFGLGEOA_;
		}
		set
		{
			fNLDFGLGEOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPPGPMEDJEF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPPGPMEDJEF(GPPGPMEDJEF other)
		: this()
	{
		jFJPDEPOFMO_ = other.jFJPDEPOFMO_.Clone();
		kGEBJNHOLCN_ = other.kGEBJNHOLCN_;
		fNLDFGLGEOA_ = ((other.fNLDFGLGEOA_ != null) ? other.fNLDFGLGEOA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPPGPMEDJEF Clone()
	{
		return new GPPGPMEDJEF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GPPGPMEDJEF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GPPGPMEDJEF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jFJPDEPOFMO_.Equals(other.jFJPDEPOFMO_))
		{
			return false;
		}
		if (KGEBJNHOLCN != other.KGEBJNHOLCN)
		{
			return false;
		}
		if (!object.Equals(FNLDFGLGEOA, other.FNLDFGLGEOA))
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
		num ^= jFJPDEPOFMO_.GetHashCode();
		if (KGEBJNHOLCN != BFPIBIEGJGJ.Cnofnjgiaod)
		{
			num ^= KGEBJNHOLCN.GetHashCode();
		}
		if (fNLDFGLGEOA_ != null)
		{
			num ^= FNLDFGLGEOA.GetHashCode();
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
		jFJPDEPOFMO_.WriteTo(ref output, _repeated_jFJPDEPOFMO_codec);
		if (KGEBJNHOLCN != BFPIBIEGJGJ.Cnofnjgiaod)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)KGEBJNHOLCN);
		}
		if (fNLDFGLGEOA_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(FNLDFGLGEOA);
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
		num += jFJPDEPOFMO_.CalculateSize(_repeated_jFJPDEPOFMO_codec);
		if (KGEBJNHOLCN != BFPIBIEGJGJ.Cnofnjgiaod)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)KGEBJNHOLCN);
		}
		if (fNLDFGLGEOA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FNLDFGLGEOA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GPPGPMEDJEF other)
	{
		if (other == null)
		{
			return;
		}
		jFJPDEPOFMO_.Add(other.jFJPDEPOFMO_);
		if (other.KGEBJNHOLCN != BFPIBIEGJGJ.Cnofnjgiaod)
		{
			KGEBJNHOLCN = other.KGEBJNHOLCN;
		}
		if (other.fNLDFGLGEOA_ != null)
		{
			if (fNLDFGLGEOA_ == null)
			{
				FNLDFGLGEOA = new ItemList();
			}
			FNLDFGLGEOA.MergeFrom(other.FNLDFGLGEOA);
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
			case 10u:
				jFJPDEPOFMO_.AddEntriesFrom(ref input, _repeated_jFJPDEPOFMO_codec);
				break;
			case 16u:
				KGEBJNHOLCN = (BFPIBIEGJGJ)input.ReadEnum();
				break;
			case 66u:
				if (fNLDFGLGEOA_ == null)
				{
					FNLDFGLGEOA = new ItemList();
				}
				input.ReadMessage(FNLDFGLGEOA);
				break;
			}
		}
	}
}
