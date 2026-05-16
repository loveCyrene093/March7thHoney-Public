using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KEHGPHDBOBD : IMessage<KEHGPHDBOBD>, IMessage, IEquatable<KEHGPHDBOBD>, IDeepCloneable<KEHGPHDBOBD>, IBufferMessage
{
	private static readonly MessageParser<KEHGPHDBOBD> _parser = new MessageParser<KEHGPHDBOBD>(() => new KEHGPHDBOBD());

	private UnknownFieldSet _unknownFields;

	public const int EIIAGABAFECFieldNumber = 2;

	private uint eIIAGABAFEC_;

	public const int AIGLOBFPEABFieldNumber = 6;

	private ItemList aIGLOBFPEAB_;

	public const int JAFNCOMGABGFieldNumber = 15;

	private uint jAFNCOMGABG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KEHGPHDBOBD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KEHGPHDBOBDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList AIGLOBFPEAB
	{
		get
		{
			return aIGLOBFPEAB_;
		}
		set
		{
			aIGLOBFPEAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAFNCOMGABG
	{
		get
		{
			return jAFNCOMGABG_;
		}
		set
		{
			jAFNCOMGABG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEHGPHDBOBD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEHGPHDBOBD(KEHGPHDBOBD other)
		: this()
	{
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		aIGLOBFPEAB_ = ((other.aIGLOBFPEAB_ != null) ? other.aIGLOBFPEAB_.Clone() : null);
		jAFNCOMGABG_ = other.jAFNCOMGABG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEHGPHDBOBD Clone()
	{
		return new KEHGPHDBOBD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KEHGPHDBOBD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KEHGPHDBOBD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EIIAGABAFEC != other.EIIAGABAFEC)
		{
			return false;
		}
		if (!object.Equals(AIGLOBFPEAB, other.AIGLOBFPEAB))
		{
			return false;
		}
		if (JAFNCOMGABG != other.JAFNCOMGABG)
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
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
		}
		if (aIGLOBFPEAB_ != null)
		{
			num ^= AIGLOBFPEAB.GetHashCode();
		}
		if (JAFNCOMGABG != 0)
		{
			num ^= JAFNCOMGABG.GetHashCode();
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
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EIIAGABAFEC);
		}
		if (aIGLOBFPEAB_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AIGLOBFPEAB);
		}
		if (JAFNCOMGABG != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(JAFNCOMGABG);
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
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
		if (aIGLOBFPEAB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AIGLOBFPEAB);
		}
		if (JAFNCOMGABG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAFNCOMGABG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KEHGPHDBOBD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EIIAGABAFEC != 0)
		{
			EIIAGABAFEC = other.EIIAGABAFEC;
		}
		if (other.aIGLOBFPEAB_ != null)
		{
			if (aIGLOBFPEAB_ == null)
			{
				AIGLOBFPEAB = new ItemList();
			}
			AIGLOBFPEAB.MergeFrom(other.AIGLOBFPEAB);
		}
		if (other.JAFNCOMGABG != 0)
		{
			JAFNCOMGABG = other.JAFNCOMGABG;
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
				EIIAGABAFEC = input.ReadUInt32();
				break;
			case 50u:
				if (aIGLOBFPEAB_ == null)
				{
					AIGLOBFPEAB = new ItemList();
				}
				input.ReadMessage(AIGLOBFPEAB);
				break;
			case 120u:
				JAFNCOMGABG = input.ReadUInt32();
				break;
			}
		}
	}
}
