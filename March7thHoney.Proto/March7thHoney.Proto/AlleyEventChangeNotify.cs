using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlleyEventChangeNotify : IMessage<AlleyEventChangeNotify>, IMessage, IEquatable<AlleyEventChangeNotify>, IDeepCloneable<AlleyEventChangeNotify>, IBufferMessage
{
	private static readonly MessageParser<AlleyEventChangeNotify> _parser = new MessageParser<AlleyEventChangeNotify>(() => new AlleyEventChangeNotify());

	private UnknownFieldSet _unknownFields;

	public const int GLNJOAHBBKKFieldNumber = 7;

	private DCMJCNOKKNN gLNJOAHBBKK_;

	public const int NDOPMMAMMODFieldNumber = 9;

	private uint nDOPMMAMMOD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlleyEventChangeNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AlleyEventChangeNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCMJCNOKKNN GLNJOAHBBKK
	{
		get
		{
			return gLNJOAHBBKK_;
		}
		set
		{
			gLNJOAHBBKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDOPMMAMMOD
	{
		get
		{
			return nDOPMMAMMOD_;
		}
		set
		{
			nDOPMMAMMOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyEventChangeNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyEventChangeNotify(AlleyEventChangeNotify other)
		: this()
	{
		gLNJOAHBBKK_ = ((other.gLNJOAHBBKK_ != null) ? other.gLNJOAHBBKK_.Clone() : null);
		nDOPMMAMMOD_ = other.nDOPMMAMMOD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyEventChangeNotify Clone()
	{
		return new AlleyEventChangeNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AlleyEventChangeNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlleyEventChangeNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GLNJOAHBBKK, other.GLNJOAHBBKK))
		{
			return false;
		}
		if (NDOPMMAMMOD != other.NDOPMMAMMOD)
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
		if (gLNJOAHBBKK_ != null)
		{
			num ^= GLNJOAHBBKK.GetHashCode();
		}
		if (NDOPMMAMMOD != 0)
		{
			num ^= NDOPMMAMMOD.GetHashCode();
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
		if (gLNJOAHBBKK_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(GLNJOAHBBKK);
		}
		if (NDOPMMAMMOD != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(NDOPMMAMMOD);
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
		if (gLNJOAHBBKK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GLNJOAHBBKK);
		}
		if (NDOPMMAMMOD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDOPMMAMMOD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlleyEventChangeNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gLNJOAHBBKK_ != null)
		{
			if (gLNJOAHBBKK_ == null)
			{
				GLNJOAHBBKK = new DCMJCNOKKNN();
			}
			GLNJOAHBBKK.MergeFrom(other.GLNJOAHBBKK);
		}
		if (other.NDOPMMAMMOD != 0)
		{
			NDOPMMAMMOD = other.NDOPMMAMMOD;
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
			case 58u:
				if (gLNJOAHBBKK_ == null)
				{
					GLNJOAHBBKK = new DCMJCNOKKNN();
				}
				input.ReadMessage(GLNJOAHBBKK);
				break;
			case 72u:
				NDOPMMAMMOD = input.ReadUInt32();
				break;
			}
		}
	}
}
