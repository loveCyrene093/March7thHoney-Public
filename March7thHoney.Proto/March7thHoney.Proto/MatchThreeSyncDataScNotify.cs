using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeSyncDataScNotify : IMessage<MatchThreeSyncDataScNotify>, IMessage, IEquatable<MatchThreeSyncDataScNotify>, IDeepCloneable<MatchThreeSyncDataScNotify>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeSyncDataScNotify> _parser = new MessageParser<MatchThreeSyncDataScNotify>(() => new MatchThreeSyncDataScNotify());

	private UnknownFieldSet _unknownFields;

	public const int DCFGOFNBLCMFieldNumber = 3;

	private MJMPDGNFIKN dCFGOFNBLCM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeSyncDataScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeSyncDataScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJMPDGNFIKN DCFGOFNBLCM
	{
		get
		{
			return dCFGOFNBLCM_;
		}
		set
		{
			dCFGOFNBLCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeSyncDataScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeSyncDataScNotify(MatchThreeSyncDataScNotify other)
		: this()
	{
		dCFGOFNBLCM_ = ((other.dCFGOFNBLCM_ != null) ? other.dCFGOFNBLCM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeSyncDataScNotify Clone()
	{
		return new MatchThreeSyncDataScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeSyncDataScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeSyncDataScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DCFGOFNBLCM, other.DCFGOFNBLCM))
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
		if (dCFGOFNBLCM_ != null)
		{
			num ^= DCFGOFNBLCM.GetHashCode();
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
		if (dCFGOFNBLCM_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(DCFGOFNBLCM);
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
		if (dCFGOFNBLCM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DCFGOFNBLCM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchThreeSyncDataScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dCFGOFNBLCM_ != null)
		{
			if (dCFGOFNBLCM_ == null)
			{
				DCFGOFNBLCM = new MJMPDGNFIKN();
			}
			DCFGOFNBLCM.MergeFrom(other.DCFGOFNBLCM);
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
			if (dCFGOFNBLCM_ == null)
			{
				DCFGOFNBLCM = new MJMPDGNFIKN();
			}
			input.ReadMessage(DCFGOFNBLCM);
		}
	}
}
