using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncMuseumRandomEventStartScNotify : IMessage<SyncMuseumRandomEventStartScNotify>, IMessage, IEquatable<SyncMuseumRandomEventStartScNotify>, IDeepCloneable<SyncMuseumRandomEventStartScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncMuseumRandomEventStartScNotify> _parser = new MessageParser<SyncMuseumRandomEventStartScNotify>(() => new SyncMuseumRandomEventStartScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LJMFGDFBLCKFieldNumber = 5;

	private AFFIMBGBMBJ lJMFGDFBLCK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncMuseumRandomEventStartScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncMuseumRandomEventStartScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFFIMBGBMBJ LJMFGDFBLCK
	{
		get
		{
			return lJMFGDFBLCK_;
		}
		set
		{
			lJMFGDFBLCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumRandomEventStartScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumRandomEventStartScNotify(SyncMuseumRandomEventStartScNotify other)
		: this()
	{
		lJMFGDFBLCK_ = ((other.lJMFGDFBLCK_ != null) ? other.lJMFGDFBLCK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumRandomEventStartScNotify Clone()
	{
		return new SyncMuseumRandomEventStartScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncMuseumRandomEventStartScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncMuseumRandomEventStartScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LJMFGDFBLCK, other.LJMFGDFBLCK))
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
		if (lJMFGDFBLCK_ != null)
		{
			num ^= LJMFGDFBLCK.GetHashCode();
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
		if (lJMFGDFBLCK_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(LJMFGDFBLCK);
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
		if (lJMFGDFBLCK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJMFGDFBLCK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncMuseumRandomEventStartScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lJMFGDFBLCK_ != null)
		{
			if (lJMFGDFBLCK_ == null)
			{
				LJMFGDFBLCK = new AFFIMBGBMBJ();
			}
			LJMFGDFBLCK.MergeFrom(other.LJMFGDFBLCK);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (lJMFGDFBLCK_ == null)
			{
				LJMFGDFBLCK = new AFFIMBGBMBJ();
			}
			input.ReadMessage(LJMFGDFBLCK);
		}
	}
}
