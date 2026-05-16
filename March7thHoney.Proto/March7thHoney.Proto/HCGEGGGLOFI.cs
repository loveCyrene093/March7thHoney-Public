using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HCGEGGGLOFI : IMessage<HCGEGGGLOFI>, IMessage, IEquatable<HCGEGGGLOFI>, IDeepCloneable<HCGEGGGLOFI>, IBufferMessage
{
	private static readonly MessageParser<HCGEGGGLOFI> _parser = new MessageParser<HCGEGGGLOFI>(() => new HCGEGGGLOFI());

	private UnknownFieldSet _unknownFields;

	public const int NJONKANPJLOFieldNumber = 1;

	private MCACDFHCPIE nJONKANPJLO_;

	public const int MPGDJOGHKBHFieldNumber = 4;

	private uint mPGDJOGHKBH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HCGEGGGLOFI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HCGEGGGLOFIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCACDFHCPIE NJONKANPJLO
	{
		get
		{
			return nJONKANPJLO_;
		}
		set
		{
			nJONKANPJLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MPGDJOGHKBH
	{
		get
		{
			return mPGDJOGHKBH_;
		}
		set
		{
			mPGDJOGHKBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCGEGGGLOFI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCGEGGGLOFI(HCGEGGGLOFI other)
		: this()
	{
		nJONKANPJLO_ = ((other.nJONKANPJLO_ != null) ? other.nJONKANPJLO_.Clone() : null);
		mPGDJOGHKBH_ = other.mPGDJOGHKBH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCGEGGGLOFI Clone()
	{
		return new HCGEGGGLOFI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HCGEGGGLOFI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HCGEGGGLOFI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NJONKANPJLO, other.NJONKANPJLO))
		{
			return false;
		}
		if (MPGDJOGHKBH != other.MPGDJOGHKBH)
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
		if (nJONKANPJLO_ != null)
		{
			num ^= NJONKANPJLO.GetHashCode();
		}
		if (MPGDJOGHKBH != 0)
		{
			num ^= MPGDJOGHKBH.GetHashCode();
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
		if (nJONKANPJLO_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(NJONKANPJLO);
		}
		if (MPGDJOGHKBH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MPGDJOGHKBH);
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
		if (nJONKANPJLO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NJONKANPJLO);
		}
		if (MPGDJOGHKBH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MPGDJOGHKBH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HCGEGGGLOFI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nJONKANPJLO_ != null)
		{
			if (nJONKANPJLO_ == null)
			{
				NJONKANPJLO = new MCACDFHCPIE();
			}
			NJONKANPJLO.MergeFrom(other.NJONKANPJLO);
		}
		if (other.MPGDJOGHKBH != 0)
		{
			MPGDJOGHKBH = other.MPGDJOGHKBH;
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
				if (nJONKANPJLO_ == null)
				{
					NJONKANPJLO = new MCACDFHCPIE();
				}
				input.ReadMessage(NJONKANPJLO);
				break;
			case 32u:
				MPGDJOGHKBH = input.ReadUInt32();
				break;
			}
		}
	}
}
