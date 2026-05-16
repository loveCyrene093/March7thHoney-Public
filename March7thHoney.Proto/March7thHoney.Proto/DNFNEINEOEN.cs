using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DNFNEINEOEN : IMessage<DNFNEINEOEN>, IMessage, IEquatable<DNFNEINEOEN>, IDeepCloneable<DNFNEINEOEN>, IBufferMessage
{
	private static readonly MessageParser<DNFNEINEOEN> _parser = new MessageParser<DNFNEINEOEN>(() => new DNFNEINEOEN());

	private UnknownFieldSet _unknownFields;

	public const int IGAFLCKJJKMFieldNumber = 3;

	private LBCNAOFKCIL iGAFLCKJJKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DNFNEINEOEN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DNFNEINEOENReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBCNAOFKCIL IGAFLCKJJKM
	{
		get
		{
			return iGAFLCKJJKM_;
		}
		set
		{
			iGAFLCKJJKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNFNEINEOEN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNFNEINEOEN(DNFNEINEOEN other)
		: this()
	{
		iGAFLCKJJKM_ = ((other.iGAFLCKJJKM_ != null) ? other.iGAFLCKJJKM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNFNEINEOEN Clone()
	{
		return new DNFNEINEOEN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DNFNEINEOEN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DNFNEINEOEN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IGAFLCKJJKM, other.IGAFLCKJJKM))
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
		if (iGAFLCKJJKM_ != null)
		{
			num ^= IGAFLCKJJKM.GetHashCode();
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
		if (iGAFLCKJJKM_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(IGAFLCKJJKM);
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
		if (iGAFLCKJJKM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IGAFLCKJJKM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DNFNEINEOEN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iGAFLCKJJKM_ != null)
		{
			if (iGAFLCKJJKM_ == null)
			{
				IGAFLCKJJKM = new LBCNAOFKCIL();
			}
			IGAFLCKJJKM.MergeFrom(other.IGAFLCKJJKM);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (iGAFLCKJJKM_ == null)
			{
				IGAFLCKJJKM = new LBCNAOFKCIL();
			}
			input.ReadMessage(IGAFLCKJJKM);
		}
	}
}
